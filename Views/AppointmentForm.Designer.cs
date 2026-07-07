using System;
using System.Windows.Forms;

namespace ClientSchedule.Views
{
    partial class AppointmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCustomer = new Label();
            cmbCustomer = new ComboBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(22, 22);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.Location = new Point(22, 40);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(240, 23);
            cmbCustomer.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(22, 75);
            lblType.Name = "lblType";
            lblType.Size = new Size(32, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(22, 93);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(240, 23);
            cmbType.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(22, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(22, 146);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(240, 23);
            txtTitle.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 181);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(22, 199);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(240, 23);
            txtDescription.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(22, 234);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(211, 15);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "(UTC-06:00) Central Time (US & Canada)";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(22, 252);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(240, 23);
            txtLocation.TabIndex = 9;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(22, 287);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(49, 15);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(22, 305);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(240, 23);
            txtContact.TabIndex = 11;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(22, 340);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 12;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(22, 358);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(240, 23);
            txtUrl.TabIndex = 13;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(22, 393);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(31, 15);
            lblStart.TabIndex = 14;
            lblStart.Text = "Start";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(22, 411);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(240, 23);
            dtpStart.TabIndex = 15;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(22, 446);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(27, 15);
            lblEnd.TabIndex = 16;
            lblEnd.Text = "End";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(22, 464);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(240, 23);
            dtpEnd.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 35);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AppointmentForm
            // 
            ClientSize = new Size(284, 561);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpEnd);
            Controls.Add(lblEnd);
            Controls.Add(dtpStart);
            Controls.Add(lblStart);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(cmbCustomer);
            Controls.Add(lblCustomer);
            Name = "AppointmentForm";
            Text = "Appointment";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}