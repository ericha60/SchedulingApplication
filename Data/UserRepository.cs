using ClientSchedule.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientSchedule.Data
{
    public static class UserRepository
    {
        public static bool ValidateLogin(string username, string password)
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = "SELECT * FROM user WHERE userName = @username AND password = @password";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public static int GetUserId(string username)
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            string query = "SELECT userId FROM user WHERE userName = @username";

            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                object result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }

        public static List<User> GetAllUsers()
        {
            DBConnection.OpenConnection();
            var conn = DBConnection.GetConnection();

            var list = new List<User>();

            string query = "SELECT userId, userName FROM user";

            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new User
                    {
                        userId = reader.GetInt32("userId"),
                        userName = reader.GetString("userName")
                    });
                }
            }

            return list;
        }

        public class User
        {
            public int userId { get; set; }
            public string userName { get; set; }
        }
    }
}