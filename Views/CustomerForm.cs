using ClientSchedule.Data;
using ClientSchedule.Models;
using ClientSchedule.Utilities;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientSchedule.Views
{
    public partial class CustomerForm : Form
    {
        private readonly bool _isEdit;
        private readonly int _customerId;

        public CustomerForm()
        {
            InitializeComponent();
            _isEdit = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public CustomerForm(int customerId, string name, string address, string phone)
        {
            InitializeComponent();
            _isEdit = true;
            _customerId = customerId;

            this.StartPosition = FormStartPosition.CenterScreen;

            txtCustomerName.Text = name;
            txtAddress.Text = address;
            txtPhone.Text = phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerRepository.Exists(txtCustomerName.Text.Trim(), txtPhone.Text.Trim()) && !_isEdit)
                {
                    MessageBox.Show("A customer with this name and phone already exists.");
                    return;
                }
                if (!ValidateFields())
                    return;

                string name = txtCustomerName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();

                try
                {
                    if (_isEdit)
                    {
                        CustomerRepository.UpdateCustomer(_customerId, name, address, phone);
                    }
                    else
                    {
                        CustomerRepository.AddCustomer(name, address, phone);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving customer: {ex.Message}");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(LocalizationService.T("SaveError"));
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show(LocalizationService.T("CustomerNameRequired"));
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show(LocalizationService.T("CustomerAddressRequired"));
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(LocalizationService.T("CustomerPhoneRequired"));
                return false;
            }

            // Digits + dashes only
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^[0-9\-]+$"))
            {
                MessageBox.Show(LocalizationService.T("CustomerPhoneInvalid"));
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}