namespace LMS
{
    partial class UC_LogsReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageAuditLogs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblAction = new System.Windows.Forms.Label();
            this.cmbActionFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterLogs = new System.Windows.Forms.Button();
            this.btnResetLogs = new System.Windows.Forms.Button();
            this.dgvAuditLogs = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.tabPageAuditLogs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Audit Logs && Analytical Reports";
            // 
            // tabPageAuditLogs
            // 
            this.tabPageAuditLogs.Controls.Add(this.tabPage1);
            this.tabPageAuditLogs.Controls.Add(this.tabPage2);
            this.tabPageAuditLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAuditLogs.Location = new System.Drawing.Point(20, 50);
            this.tabPageAuditLogs.Name = "tabPageAuditLogs";
            this.tabPageAuditLogs.SelectedIndex = 0;
            this.tabPageAuditLogs.Size = new System.Drawing.Size(872, 515);
            this.tabPageAuditLogs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAuditLogs);
            this.tabPage1.Controls.Add(this.btnResetLogs);
            this.tabPage1.Controls.Add(this.btnFilterLogs);
            this.tabPage1.Controls.Add(this.cmbActionFilter);
            this.tabPage1.Controls.Add(this.lblAction);
            this.tabPage1.Controls.Add(this.dtpToDate);
            this.tabPage1.Controls.Add(this.lblTo);
            this.tabPage1.Controls.Add(this.dtpFromDate);
            this.tabPage1.Controls.Add(this.lblFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvReports);
            this.tabPage2.Controls.Add(this.btnGenerateReport);
            this.tabPage2.Controls.Add(this.cmbReportType);
            this.tabPage2.Controls.Add(this.lblReportType);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(15, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(85, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(106, 18);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 27);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(242, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(85, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To Date:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(311, 18);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 27);
            this.dtpToDate.TabIndex = 3;
            // 
            // lblAction
            // 
            this.lblAction.Location = new System.Drawing.Point(447, 18);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(85, 20);
            this.lblAction.TabIndex = 4;
            this.lblAction.Text = "Action:";
            // 
            // cmbActionFilter
            // 
            this.cmbActionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionFilter.FormattingEnabled = true;
            this.cmbActionFilter.Location = new System.Drawing.Point(500, 15);
            this.cmbActionFilter.Name = "cmbActionFilter";
            this.cmbActionFilter.Size = new System.Drawing.Size(140, 28);
            this.cmbActionFilter.TabIndex = 5;
            // 
            // btnFilterLogs
            // 
            this.btnFilterLogs.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFilterLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterLogs.ForeColor = System.Drawing.Color.White;
            this.btnFilterLogs.Location = new System.Drawing.Point(655, 13);
            this.btnFilterLogs.Name = "btnFilterLogs";
            this.btnFilterLogs.Size = new System.Drawing.Size(100, 28);
            this.btnFilterLogs.TabIndex = 6;
            this.btnFilterLogs.Text = "Apply Filter";
            this.btnFilterLogs.UseVisualStyleBackColor = false;
            this.btnFilterLogs.Click += new System.EventHandler(this.btnFilterLogs_Click);
            // 
            // btnResetLogs
            // 
            this.btnResetLogs.BackColor = System.Drawing.Color.DimGray;
            this.btnResetLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLogs.ForeColor = System.Drawing.Color.White;
            this.btnResetLogs.Location = new System.Drawing.Point(762, 13);
            this.btnResetLogs.Name = "btnResetLogs";
            this.btnResetLogs.Size = new System.Drawing.Size(85, 28);
            this.btnResetLogs.TabIndex = 7;
            this.btnResetLogs.Text = "Reset";
            this.btnResetLogs.UseVisualStyleBackColor = false;
            this.btnResetLogs.Click += new System.EventHandler(this.btnResetLogs_Click);
            // 
            // dgvAuditLogs
            // 
            this.dgvAuditLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAuditLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditLogs.Location = new System.Drawing.Point(15, 55);
            this.dgvAuditLogs.Name = "dgvAuditLogs";
            this.dgvAuditLogs.ReadOnly = true;
            this.dgvAuditLogs.RowHeadersWidth = 51;
            this.dgvAuditLogs.RowTemplate.Height = 24;
            this.dgvAuditLogs.Size = new System.Drawing.Size(835, 415);
            this.dgvAuditLogs.TabIndex = 8;
            // 
            // lblReportType
            // 
            this.lblReportType.Location = new System.Drawing.Point(15, 28);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(101, 20);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Select Report:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(122, 25);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(240, 28);
            this.cmbReportType.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(368, 25);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(135, 28);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(15, 55);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(835, 415);
            this.dgvReports.TabIndex = 4;
            // 
            // UC_LogsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabPageAuditLogs);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_LogsReports";
            this.Size = new System.Drawing.Size(912, 573);
            this.tabPageAuditLogs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabPageAuditLogs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnResetLogs;
        private System.Windows.Forms.Button btnFilterLogs;
        private System.Windows.Forms.ComboBox cmbActionFilter;
        private System.Windows.Forms.DataGridView dgvAuditLogs;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}
