using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ClientSchedule.Models;
using ClientSchedule.Utilities;

namespace ClientSchedule.Data
{
    public static class AppointmentRepository
    {
        public static List<Appointment> GetAllAppointments()
        {
            var list = new List<Appointment>();

            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = @"
                SELECT appointmentId, customerId, userId, title, description,
                       location, contact, type, url, start, end
                FROM appointment";

            using (var cmd = new MySqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Appointment
                    {
                        appointmentId = reader.GetInt32("appointmentId"),
                        customerId = reader.GetInt32("customerId"),
                        userId = reader.GetInt32("userId"),
                        title = reader.GetString("title"),
                        description = reader.GetString("description"),
                        location = reader.GetString("location"),
                        contact = reader.GetString("contact"),
                        type = reader.GetString("type"),
                        url = reader.GetString("url"),
                        start = TimeZoneHelper.FromUTC(reader.GetDateTime("start")),
                        end = TimeZoneHelper.FromUTC(reader.GetDateTime("end")),
                    });
                }
            }

            return list;
        }

        public static void AddAppointment(Appointment appt)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                string query = @"
                    INSERT INTO appointment
                    (customerId, userId, title, description, location, contact,
                     type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES
                    (@customerId, @userId, @title, @description, @location, @contact,
                     @type, @url, @start, @end, NOW(), 'system', NOW(), 'system')";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", appt.customerId);
                    cmd.Parameters.AddWithValue("@userId", appt.userId);
                    cmd.Parameters.AddWithValue("@title", appt.title);
                    cmd.Parameters.AddWithValue("@description", appt.description);
                    cmd.Parameters.AddWithValue("@location", appt.location);
                    cmd.Parameters.AddWithValue("@contact", appt.contact);
                    cmd.Parameters.AddWithValue("@type", appt.type);
                    cmd.Parameters.AddWithValue("@url", appt.url);
                    cmd.Parameters.AddWithValue("@start", TimeZoneHelper.ToUTC(appt.start));
                    cmd.Parameters.AddWithValue("@end", TimeZoneHelper.ToUTC(appt.end));
                    // Store in UTC to satisfy time zone + DST requirements
                    cmd.Parameters.AddWithValue("@start", TimeZoneHelper.ToUTC(appt.start));
                    cmd.Parameters.AddWithValue("@end", TimeZoneHelper.ToUTC(appt.end));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateAppointment(Appointment appt)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                string query = @"
                    UPDATE appointment
                    SET customerId = @customerId,
                        userId = @userId,
                        title = @title,
                        description = @description,
                        location = @location,
                        contact = @contact,
                        type = @type,
                        url = @url,
                        start = @start,
                        end = @end,
                        lastUpdate = NOW(),
                        lastUpdateBy = 'system'
                    WHERE appointmentId = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", appt.appointmentId);
                    // Store in UTC to satisfy time zone + DST requirements
                    cmd.Parameters.AddWithValue("@start", TimeZoneHelper.ToUTC(appt.start));
                    cmd.Parameters.AddWithValue("@end", TimeZoneHelper.ToUTC(appt.end));
                    cmd.Parameters.AddWithValue("@customerId", appt.customerId);
                    cmd.Parameters.AddWithValue("@userId", appt.userId);
                    cmd.Parameters.AddWithValue("@title", appt.title);
                    cmd.Parameters.AddWithValue("@description", appt.description);
                    cmd.Parameters.AddWithValue("@location", appt.location);
                    cmd.Parameters.AddWithValue("@contact", appt.contact);
                    cmd.Parameters.AddWithValue("@type", appt.type);
                    cmd.Parameters.AddWithValue("@url", appt.url);
                    cmd.Parameters.AddWithValue("@start", TimeZoneHelper.ToUTC(appt.start));
                    cmd.Parameters.AddWithValue("@end", TimeZoneHelper.ToUTC(appt.end));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteAppointment(int id)
        {
            try
            {
                DBConnection.OpenConnection();
                var conn = DBConnection.GetConnection();

                string query = "DELETE FROM appointment WHERE appointmentId = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Overlaps(Appointment appt)
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = @"
                SELECT COUNT(*) FROM appointment
                WHERE userId = @userId
                AND appointmentId <> @id
                AND (
                    (@start < end AND @end > start)
                )";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", appt.userId);
                cmd.Parameters.AddWithValue("@id", appt.appointmentId);
                cmd.Parameters.AddWithValue("@start", TimeZoneHelper.ToUTC(appt.start));
                cmd.Parameters.AddWithValue("@end", TimeZoneHelper.ToUTC(appt.end));

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public static bool CheckUpcomingAppointments(int userId)
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            // Now (UTC) and 15 minutes from now (UTC)
            DateTime nowLocal = DateTime.Now;
            DateTime nowUtc = TimeZoneHelper.ToUTC(nowLocal);
            DateTime fifteenUtc = nowUtc.AddMinutes(15);

            string query = @"
        SELECT COUNT(*) FROM appointment
        WHERE userId = @userId
        AND start BETWEEN @nowUtc AND @fifteenUtc";

            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@nowUtc", nowUtc);
                cmd.Parameters.AddWithValue("@fifteenUtc", fifteenUtc);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}