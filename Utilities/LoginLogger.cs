using System;
using System.IO;

namespace ClientSchedule.Utilities
{
    public static class LoginLogger
    {
        private static readonly string LogPath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login_History.txt");

        public static void Append(string username)
        {
            File.AppendAllText(LogPath,
                $"{DateTime.Now}: SUCCESSFUL LOGIN by {username}{Environment.NewLine}");
        }

        public static void AppendFailed(string username)
        {
            File.AppendAllText(LogPath,
                $"{DateTime.Now}: FAILED LOGIN attempt for {username}{Environment.NewLine}");
        }
    }
}