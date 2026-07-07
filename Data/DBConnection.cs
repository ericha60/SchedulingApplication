using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClientSchedule.Data
{
    public static class DBConnection
    {
        private static MySqlConnection connection;

        private const string connectionString =
            "server=127.0.0.1;user id=sqlUser;password=Passw0rd!;database=client_schedule;";

        public static void OpenConnection()
        {
            if (connection == null)
                connection = new MySqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}