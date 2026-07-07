namespace ClientSchedule.Views
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(285, 164);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 0;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(288, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 1;

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(335, 269);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 2;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(351, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(123, 23);
            this.txtUsername.TabIndex = 3;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(351, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(351, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 26);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(420, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // cmbLanguage
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.Location = new System.Drawing.Point(22, 40);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(150, 23);
            this.cmbLanguage.TabIndex = 7;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);

            // lblLocation
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(22, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(200, 15);
            this.lblLocation.TabIndex = 8;

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Schedule - Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblMessage;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblLocation;
        private System.Windows.Forms.ComboBox cmbLanguage;
    }
}