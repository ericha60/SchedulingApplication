using ClientSchedule.Data;

namespace ClientSchedule.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            dgvCustomers = new DataGridView();
            btnAddCustomer = new Button();
            btnModifyCustomer = new Button();
            btnDeleteCustomer = new Button();
            dgvAppointments = new DataGridView();
            btnAddAppointment = new Button();
            btnModifyAppointment = new Button();
            btnDeleteAppointment = new Button();
            btnReport = new Button();
            btnCalendar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 100);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(332, 193);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(12, 299);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(83, 39);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnModifyCustomer
            // 
            btnModifyCustomer.Location = new Point(118, 299);
            btnModifyCustomer.Name = "btnModifyCustomer";
            btnModifyCustomer.Size = new Size(83, 39);
            btnModifyCustomer.TabIndex = 3;
            btnModifyCustomer.Text = "Modify";
            btnModifyCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(232, 299);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(83, 39);
            btnDeleteCustomer.TabIndex = 4;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(444, 100);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(332, 193);
            dgvAppointments.TabIndex = 5;
            dgvAppointments.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(444, 299);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(83, 39);
            btnAddAppointment.TabIndex = 6;
            btnAddAppointment.Text = "Add";
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // btnModifyAppointment
            // 
            btnModifyAppointment.Location = new Point(570, 299);
            btnModifyAppointment.Name = "btnModifyAppointment";
            btnModifyAppointment.Size = new Size(83, 39);
            btnModifyAppointment.TabIndex = 7;
            btnModifyAppointment.Text = "Modify";
            btnModifyAppointment.UseVisualStyleBackColor = true;
            btnModifyAppointment.Click += btnModifyAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(693, 299);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(83, 39);
            btnDeleteAppointment.TabIndex = 8;
            btnDeleteAppointment.Text = "Delete";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(193, 392);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(151, 46);
            btnReport.TabIndex = 21;
            btnReport.Text = "Reports";
            btnReport.Click += btnReports_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Location = new Point(12, 392);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(162, 46);
            btnCalendar.TabIndex = 20;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalendar);
            Controls.Add(btnReport);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnModifyAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(dgvAppointments);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnModifyCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCustomers);
            Controls.Add(lblWelcome);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private DataGridView dgvCustomers;
        private Button btnAddCustomer;
        private Button btnModifyCustomer;
        private Button btnDeleteCustomer;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            int id = (int)dgvCustomers.CurrentRow.Cells["customerId"].Value;
            string name = dgvCustomers.CurrentRow.Cells["customerName"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete customer '{name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            bool success = CustomerRepository.DeleteCustomer(id);

            if (!success)
                MessageBox.Show("Cannot delete customer with existing appointments.");
            else
                LoadCustomers();
        }


        private DataGridView dgvAppointments;
        private Button btnAddAppointment;
        private Button btnModifyAppointment;
        private Button btnDeleteAppointment;
        private Button btnReport;
        private System.Windows.Forms.Button btnCalendar;
    }
}