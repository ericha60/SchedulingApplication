using System;
using System.Windows.Forms;
using ClientSchedule.Views;

namespace ClientSchedule
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}