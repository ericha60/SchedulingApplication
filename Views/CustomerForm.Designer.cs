namespace ClientSchedule.Views
{
    partial class CustomerForm
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
            lblName = new Label();
            txtCustomerName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(22, 40);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(240, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(22, 75);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(22, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 23);
            txtAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(22, 128);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(22, 146);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(172, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            ClientSize = new Size(284, 251);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(lblName);
            Name = "CustomerForm";
            Text = "Customer";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}