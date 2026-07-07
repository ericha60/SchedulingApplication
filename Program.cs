using ClientSchedule.Views;
using ClientSchedule.Utilities;

namespace ClientSchedule
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Localization.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.LoginForm());
        }
    }
}