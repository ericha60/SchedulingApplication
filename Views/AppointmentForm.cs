using System;
using System.Windows.Forms;
using ClientSchedule.Data;
using ClientSchedule.Models;
using ClientSchedule.Utilities;

namespace ClientSchedule.Views
{
    public partial class AppointmentForm : Form
    {
        private readonly bool _isEdit;
        private readonly int _appointmentId;
        private readonly string _username;

        public AppointmentForm(string username)
        {
            InitializeComponent();
            _isEdit = false;
            _username = username;

            this.StartPosition = FormStartPosition.CenterScreen;

            LoadCustomers();
            LoadTypes();
        }

        public AppointmentForm(string username, int appointmentId)
        {
            InitializeComponent();
            _isEdit = true;
            _appointmentId = appointmentId;
            _username = username;

            this.StartPosition = FormStartPosition.CenterScreen;

            LoadCustomers();
            LoadTypes();
            LoadAppointmentData();
        }

        private void LoadCustomers()
        {
            var customers = CustomerRepository.GetAllCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "customerName";
            cmbCustomer.ValueMember = "customerId";
        }

        private void LoadTypes()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Planning");
            cmbType.Items.Add("Presentation");
            cmbType.Items.Add("Scrum");
            cmbType.Items.Add("Consultation");
            cmbType.Items.Add("Review");
            cmbType.Items.Add("Other");
        }

        private void LoadAppointmentData()
        {
            var list = AppointmentRepository.GetAllAppointments();
            var appt = list.Find(a => a.appointmentId == _appointmentId);

            if (appt == null)
                return;

            cmbCustomer.SelectedValue = appt.customerId;
            cmbType.SelectedItem = appt.type;

            txtTitle.Text = appt.title;
            txtDescription.Text = appt.description;
            txtLocation.Text = appt.location;
            txtContact.Text = appt.contact;
            txtUrl.Text = appt.url;

            dtpStart.Value = appt.start;
            dtpEnd.Value = appt.end;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Appointment appt = new Appointment
            {
                appointmentId = _appointmentId,
                customerId = (int)cmbCustomer.SelectedValue,
                userId = GetUserId(_username),
                title = txtTitle.Text,
                description = txtDescription.Text,
                location = txtLocation.Text,
                contact = txtContact.Text,
                type = cmbType.SelectedItem.ToString(),
                url = txtUrl.Text,
                start = dtpStart.Value,
                end = dtpEnd.Value
            };

            if (!TimeZoneHelper.IsWithinBusinessHours(appt.start, appt.end))
            {
                MessageBox.Show(LocalizationService.T("AppointmentHours"));
                return;
            }

            if (AppointmentRepository.Overlaps(appt))
            {
                MessageBox.Show(LocalizationService.T("AppointmentOverlap"));
                return;
            }

            try
            {
                if (_isEdit)
                    AppointmentRepository.UpdateAppointment(appt);
                else
                    AppointmentRepository.AddAppointment(appt);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving appointment: {ex.Message}");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private int GetUserId(string username)
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

        private bool ValidateFields()
        {
            if (cmbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.");
                return false;
            }

            if (cmbType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an appointment type.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return false;
            }

            if (dtpEnd.Value <= dtpStart.Value)
            {
                MessageBox.Show("End time must be after start time.");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}