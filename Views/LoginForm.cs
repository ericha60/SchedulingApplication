using ClientSchedule.Utilities;
using System;
using System.Windows.Forms;
using ClientSchedule.Data;

namespace ClientSchedule.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeLocalization();
        }

        private void InitializeLocalization()
        {
            // Populate language dropdown
            cmbLanguage.Items.Add("English");
            cmbLanguage.Items.Add("Español");
            cmbLanguage.SelectedIndex = 0;

            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            lblUsername.Text = LocalizationService.T("lbl_username");
            lblPassword.Text = LocalizationService.T("lbl_password");
            btnLogin.Text = LocalizationService.T("btn_login");
            btnExit.Text = LocalizationService.T("btn_exit");
            cmbLanguage.Text = LocalizationService.T("lbl_language");
            lblLocation.Text = $"{LocalizationService.T("lbl_location")}: {TimeZoneInfo.Local.DisplayName}";
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex == 0)
                LocalizationService.SetCulture("en-US");
            else
                LocalizationService.SetCulture("es-ES");

            ApplyLocalization();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblMessage.Text = LocalizationService.T("username_required");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = LocalizationService.T("password_required");
                return;
            }

            bool success = UserRepository.ValidateLogin(txtUsername.Text, txtPassword.Text);

            if (success)
            {
                LoginLogger.Append(txtUsername.Text);
                lblMessage.Text = LocalizationService.T("login_success");

                int userId = UserRepository.GetUserId(txtUsername.Text);
                bool hasUpcoming = AppointmentRepository.CheckUpcomingAppointments(userId);

                if (hasUpcoming)
                {
                    MessageBox.Show(
                        LocalizationService.T("appointment_alert"),
                        LocalizationService.T("alert_title"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.Hide();
                new MainForm(txtUsername.Text).Show();
            }
            else
            {
                LoginLogger.AppendFailed(txtUsername.Text);
                lblMessage.Text = LocalizationService.T("login_failed");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}