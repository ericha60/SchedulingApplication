using ClientSchedule.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientSchedule.Views
{
    public partial class MainForm : Form
    {
        private readonly string _username;

        public MainForm(string username)
        {
            InitializeComponent();
            _username = username;

            lblWelcome.Text = $"Welcome, {_username}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAppointments();
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = CustomerRepository.GetAllCustomers();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = AppointmentRepository.GetAllAppointments();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm(_username);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            int id = (int)dgvCustomers.CurrentRow.Cells["customerId"].Value;
            string name = dgvCustomers.CurrentRow.Cells["customerName"].Value.ToString();
            string address = dgvCustomers.CurrentRow.Cells["address"].Value.ToString();
            string phone = dgvCustomers.CurrentRow.Cells["phone"].Value.ToString();

            var form = new CustomerForm(id, name, address, phone);
            if (form.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            int id = (int)dgvAppointments.CurrentRow.Cells["appointmentId"].Value;
            string title = dgvAppointments.CurrentRow.Cells["title"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete appointment '{title}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            AppointmentRepository.DeleteAppointment(id);
            LoadAppointments();
        }

        private void btnModifyAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            int id = (int)dgvAppointments.CurrentRow.Cells["appointmentId"].Value;

            var form = new AppointmentForm(_username, id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            var form = new CalendarForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new ReportsForm();
            form.ShowDialog();
        }
    }
}