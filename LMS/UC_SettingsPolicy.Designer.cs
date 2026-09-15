namespace LMS
{
    partial class UC_SettingsPolicy
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSettings = new System.Windows.Forms.DataGridView();
            this.grpFinePolicy = new System.Windows.Forms.GroupBox();
            this.lblDailyFine = new System.Windows.Forms.Label();
            this.txtDailyFine = new System.Windows.Forms.TextBox();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.grpLoanSettings = new System.Windows.Forms.GroupBox();
            this.lblStudentLoan = new System.Windows.Forms.Label();
            this.txtStudentLoanDays = new System.Windows.Forms.TextBox();
            this.lblFacultyLoan = new System.Windows.Forms.Label();
            this.txtFacultyLoanDays = new System.Windows.Forms.TextBox();
            this.lblMaxBooks = new System.Windows.Forms.Label();
            this.txtMaxBooks = new System.Windows.Forms.TextBox();
            this.btnSavePolicies = new System.Windows.Forms.Button();
            this.btnRefreshSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Configuration && Policies";
            // 
            // dgvSettings
            // 
            this.dgvSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSettings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettings.Location = new System.Drawing.Point(25, 55);
            this.dgvSettings.Name = "dgvSettings";
            this.dgvSettings.ReadOnly = true;
            this.dgvSettings.RowHeadersWidth = 51;
            this.dgvSettings.RowTemplate.Height = 24;
            this.dgvSettings.Size = new System.Drawing.Size(862, 230);
            this.dgvSettings.TabIndex = 1;
            // 
            // grpFinePolicy
            // 
            this.grpFinePolicy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFinePolicy.Location = new System.Drawing.Point(25, 305);
            this.grpFinePolicy.Name = "grpFinePolicy";
            this.grpFinePolicy.Size = new System.Drawing.Size(410, 180);
            this.grpFinePolicy.TabIndex = 2;
            this.grpFinePolicy.TabStop = false;
            this.grpFinePolicy.Text = "Fine Policy Management";
            // 
            // lblDailyFine
            // 
            this.lblDailyFine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyFine.Location = new System.Drawing.Point(45, 345);
            this.lblDailyFine.Name = "lblDailyFine";
            this.lblDailyFine.Size = new System.Drawing.Size(160, 20);
            this.lblDailyFine.TabIndex = 3;
            this.lblDailyFine.Text = "Daily Fine Rate ($):";
            // 
            // txtDailyFine
            // 
            this.txtDailyFine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyFine.Location = new System.Drawing.Point(220, 342);
            this.txtDailyFine.Name = "txtDailyFine";
            this.txtDailyFine.Size = new System.Drawing.Size(190, 30);
            this.txtDailyFine.TabIndex = 4;
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGracePeriod.Location = new System.Drawing.Point(45, 400);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(160, 20);
            this.lblGracePeriod.TabIndex = 5;
            this.lblGracePeriod.Text = "Grace Period (Days):";
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracePeriod.Location = new System.Drawing.Point(220, 397);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(190, 30);
            this.txtGracePeriod.TabIndex = 6;
            // 
            // grpLoanSettings
            // 
            this.grpLoanSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanSettings.Location = new System.Drawing.Point(477, 305);
            this.grpLoanSettings.Name = "grpLoanSettings";
            this.grpLoanSettings.Size = new System.Drawing.Size(410, 180);
            this.grpLoanSettings.TabIndex = 7;
            this.grpLoanSettings.TabStop = false;
            this.grpLoanSettings.Text = "Borrowing Rules && Limits";
            // 
            // lblStudentLoan
            // 
            this.lblStudentLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLoan.Location = new System.Drawing.Point(495, 335);
            this.lblStudentLoan.Name = "lblStudentLoan";
            this.lblStudentLoan.Size = new System.Drawing.Size(194, 20);
            this.lblStudentLoan.TabIndex = 8;
            this.lblStudentLoan.Text = "Student Loan Period (Days):";
            // 
            // txtStudentLoanDays
            // 
            this.txtStudentLoanDays.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentLoanDays.Location = new System.Drawing.Point(690, 332);
            this.txtStudentLoanDays.Name = "txtStudentLoanDays";
            this.txtStudentLoanDays.Size = new System.Drawing.Size(175, 30);
            this.txtStudentLoanDays.TabIndex = 9;
            // 
            // lblFacultyLoan
            // 
            this.lblFacultyLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyLoan.Location = new System.Drawing.Point(495, 385);
            this.lblFacultyLoan.Name = "lblFacultyLoan";
            this.lblFacultyLoan.Size = new System.Drawing.Size(194, 20);
            this.lblFacultyLoan.TabIndex = 10;
            this.lblFacultyLoan.Text = "Faculty Loan Period (Days):";
            // 
            // txtFacultyLoanDays
            // 
            this.txtFacultyLoanDays.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyLoanDays.Location = new System.Drawing.Point(690, 382);
            this.txtFacultyLoanDays.Name = "txtFacultyLoanDays";
            this.txtFacultyLoanDays.Size = new System.Drawing.Size(175, 30);
            this.txtFacultyLoanDays.TabIndex = 11;
            // 
            // lblMaxBooks
            // 
            this.lblMaxBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxBooks.Location = new System.Drawing.Point(495, 435);
            this.lblMaxBooks.Name = "lblMaxBooks";
            this.lblMaxBooks.Size = new System.Drawing.Size(185, 20);
            this.lblMaxBooks.TabIndex = 12;
            this.lblMaxBooks.Text = "Max Allowed Books:";
            // 
            // txtMaxBooks
            // 
            this.txtMaxBooks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxBooks.Location = new System.Drawing.Point(690, 432);
            this.txtMaxBooks.Name = "txtMaxBooks";
            this.txtMaxBooks.Size = new System.Drawing.Size(175, 30);
            this.txtMaxBooks.TabIndex = 13;
            // 
            // btnSavePolicies
            // 
            this.btnSavePolicies.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSavePolicies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePolicies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePolicies.ForeColor = System.Drawing.Color.White;
            this.btnSavePolicies.Location = new System.Drawing.Point(210, 505);
            this.btnSavePolicies.Name = "btnSavePolicies";
            this.btnSavePolicies.Size = new System.Drawing.Size(225, 52);
            this.btnSavePolicies.TabIndex = 14;
            this.btnSavePolicies.Text = "Save Policies && Settings";
            this.btnSavePolicies.UseVisualStyleBackColor = false;
            this.btnSavePolicies.Click += new System.EventHandler(this.btnSavePolicies_Click);
            // 
            // btnRefreshSettings
            // 
            this.btnRefreshSettings.BackColor = System.Drawing.Color.DimGray;
            this.btnRefreshSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSettings.ForeColor = System.Drawing.Color.White;
            this.btnRefreshSettings.Location = new System.Drawing.Point(449, 505);
            this.btnRefreshSettings.Name = "btnRefreshSettings";
            this.btnRefreshSettings.Size = new System.Drawing.Size(200, 42);
            this.btnRefreshSettings.TabIndex = 15;
            this.btnRefreshSettings.Text = "Refresh";
            this.btnRefreshSettings.UseVisualStyleBackColor = false;
            this.btnRefreshSettings.Click += new System.EventHandler(this.btnRefreshSettings_Click);
            // 
            // UC_SettingsPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshSettings);
            this.Controls.Add(this.btnSavePolicies);
            this.Controls.Add(this.txtMaxBooks);
            this.Controls.Add(this.lblMaxBooks);
            this.Controls.Add(this.txtFacultyLoanDays);
            this.Controls.Add(this.lblFacultyLoan);
            this.Controls.Add(this.txtStudentLoanDays);
            this.Controls.Add(this.lblStudentLoan);
            this.Controls.Add(this.grpLoanSettings);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.lblGracePeriod);
            this.Controls.Add(this.txtDailyFine);
            this.Controls.Add(this.lblDailyFine);
            this.Controls.Add(this.grpFinePolicy);
            this.Controls.Add(this.dgvSettings);
            this.Controls.Add(this.label1);
            this.Name = "UC_SettingsPolicy";
            this.Size = new System.Drawing.Size(912, 573);
            this.Load += new System.EventHandler(this.UC_SettingsPolicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSettings;
        private System.Windows.Forms.GroupBox grpFinePolicy;
        private System.Windows.Forms.Label lblDailyFine;
        private System.Windows.Forms.TextBox txtDailyFine;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.GroupBox grpLoanSettings;
        private System.Windows.Forms.Label lblStudentLoan;
        private System.Windows.Forms.TextBox txtStudentLoanDays;
        private System.Windows.Forms.Label lblFacultyLoan;
        private System.Windows.Forms.TextBox txtFacultyLoanDays;
        private System.Windows.Forms.Label lblMaxBooks;
        private System.Windows.Forms.TextBox txtMaxBooks;
        private System.Windows.Forms.Button btnSavePolicies;
        private System.Windows.Forms.Button btnRefreshSettings;
    }
}
