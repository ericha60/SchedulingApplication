namespace ClientSchedule.Views
{
    partial class CalendarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView dgvDayAppointments;

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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvDayAppointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // dgvDayAppointments
            // 
            this.dgvDayAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayAppointments.Location = new System.Drawing.Point(18, 192);
            this.dgvDayAppointments.Name = "dgvDayAppointments";
            this.dgvDayAppointments.Size = new System.Drawing.Size(450, 200);
            this.dgvDayAppointments.TabIndex = 1;
            // 
            // CalendarForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.dgvDayAppointments);
            this.Controls.Add(this.monthCalendar);
            this.Name = "CalendarForm";
            this.Text = "Calendar View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayAppointments)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}