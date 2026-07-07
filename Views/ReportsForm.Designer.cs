namespace ClientSchedule.Views
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReport1 = new System.Windows.Forms.Button();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // btnReport1
            this.btnReport1.Location = new System.Drawing.Point(22, 22);
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.Size = new System.Drawing.Size(200, 35);
            this.btnReport1.TabIndex = 0;
            this.btnReport1.UseVisualStyleBackColor = true;
            this.btnReport1.Click += new System.EventHandler(this.btnReport1_Click);

            // btnReport2
            this.btnReport2.Location = new System.Drawing.Point(22, 63);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(200, 35);
            this.btnReport2.TabIndex = 1;
            this.btnReport2.UseVisualStyleBackColor = true;
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);

            // btnReport3
            this.btnReport3.Location = new System.Drawing.Point(22, 104);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(200, 35);
            this.btnReport3.TabIndex = 2;
            this.btnReport3.UseVisualStyleBackColor = true;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);

            // dgvReport
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(22, 160);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(600, 300);
            this.dgvReport.TabIndex = 3;

            // ReportsForm
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnReport3);
            this.Controls.Add(this.btnReport2);
            this.Controls.Add(this.btnReport1);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }
    }
}