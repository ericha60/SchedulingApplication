using System;
using System.Windows.Forms;
using ClientSchedule.Data;
using ClientSchedule.Utilities;

namespace ClientSchedule.Views
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            this.Text = LocalizationService.T("reports_title");
            btnReport1.Text = LocalizationService.T("btn_report1");
            btnReport2.Text = LocalizationService.T("btn_report2");
            btnReport3.Text = LocalizationService.T("btn_report3");
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = ReportRepository.GetAppointmentTypeReport();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = ReportRepository.GetConsultantSchedule();
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = ReportRepository.GetCustomerAppointmentReport();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ApplyLocalization();
        }
    }
}