using System;
using System.Linq;
using System.Windows.Forms;
using ClientSchedule.Data;
using ClientSchedule.Utilities;

namespace ClientSchedule.Views
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadAppointmentsForDay(e.Start);
        }

        private void LoadAppointmentsForDay(DateTime day)
        {
            var all = AppointmentRepository.GetAllAppointments();

            // Local time comparison
            var filtered = all.Where(a =>
                a.start.Date == day.Date).ToList();

            dgvDayAppointments.DataSource = filtered;
        }
    }
}