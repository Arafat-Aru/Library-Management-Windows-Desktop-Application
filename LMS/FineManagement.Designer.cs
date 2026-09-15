namespace LMS
{
    partial class FineManagement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.txtIssueID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.btnCollectFine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFinePayments = new System.Windows.Forms.GroupBox();
            this.dgvFinePayments = new System.Windows.Forms.DataGridView();
            this.grpFinePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinePayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(259, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FINE MANAGEMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIssueID
            // 
            this.lblIssueID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueID.Location = new System.Drawing.Point(80, 100);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(100, 25);
            this.lblIssueID.TabIndex = 1;
            this.lblIssueID.Text = "Issue ID:";
            this.lblIssueID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIssueID
            // 
            this.txtIssueID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueID.Location = new System.Drawing.Point(227, 100);
            this.txtIssueID.Name = "txtIssueID";
            this.txtIssueID.Size = new System.Drawing.Size(223, 31);
            this.txtIssueID.TabIndex = 2;
            // 
            // lblMemberID
            // 
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(80, 145);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(117, 25);
            this.lblMemberID.TabIndex = 3;
            this.lblMemberID.Text = "Member ID:";
            this.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(227, 145);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(220, 31);
            this.txtMemberID.TabIndex = 4;
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.Location = new System.Drawing.Point(80, 190);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(124, 31);
            this.lblFineAmount.TabIndex = 5;
            this.lblFineAmount.Text = "Fine Amount:";
            this.lblFineAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineAmount.Location = new System.Drawing.Point(227, 190);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(220, 31);
            this.txtFineAmount.TabIndex = 6;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(80, 235);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(133, 25);
            this.lblPaymentDate.TabIndex = 7;
            this.lblPaymentDate.Text = "Payment Date:";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(227, 235);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(220, 31);
            this.dtpPaymentDate.TabIndex = 8;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(80, 280);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(144, 25);
            this.lblPaymentStatus.TabIndex = 9;
            this.lblPaymentStatus.Text = "Payment Status:";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(227, 280);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(220, 33);
            this.cmbPaymentStatus.TabIndex = 10;
            // 
            // btnCollectFine
            // 
            this.btnCollectFine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectFine.Location = new System.Drawing.Point(80, 330);
            this.btnCollectFine.Name = "btnCollectFine";
            this.btnCollectFine.Size = new System.Drawing.Size(140, 40);
            this.btnCollectFine.TabIndex = 11;
            this.btnCollectFine.Text = "Collect Fine";
            this.btnCollectFine.UseVisualStyleBackColor = true;
            this.btnCollectFine.Click += new System.EventHandler(this.btnCollectFine_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(235, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(350, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpFinePayments
            // 
            this.grpFinePayments.Controls.Add(this.dgvFinePayments);
            this.grpFinePayments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFinePayments.Location = new System.Drawing.Point(40, 395);
            this.grpFinePayments.Name = "grpFinePayments";
            this.grpFinePayments.Size = new System.Drawing.Size(800, 190);
            this.grpFinePayments.TabIndex = 14;
            this.grpFinePayments.TabStop = false;
            this.grpFinePayments.Text = "Fine Payment List";
            // 
            // dgvFinePayments
            // 
            this.dgvFinePayments.AllowUserToAddRows = false;
            this.dgvFinePayments.AllowUserToDeleteRows = false;
            this.dgvFinePayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinePayments.Location = new System.Drawing.Point(15, 30);
            this.dgvFinePayments.MultiSelect = false;
            this.dgvFinePayments.Name = "dgvFinePayments";
            this.dgvFinePayments.ReadOnly = true;
            this.dgvFinePayments.RowHeadersVisible = false;
            this.dgvFinePayments.RowHeadersWidth = 51;
            this.dgvFinePayments.RowTemplate.Height = 24;
            this.dgvFinePayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinePayments.Size = new System.Drawing.Size(770, 145);
            this.dgvFinePayments.TabIndex = 0;
            this.dgvFinePayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinePayments_CellContentClick);
            // 
            // FineManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.grpFinePayments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCollectFine);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.txtFineAmount);
            this.Controls.Add(this.lblFineAmount);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.txtIssueID);
            this.Controls.Add(this.lblIssueID);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FineManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fine Management";
            this.grpFinePayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinePayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.TextBox txtIssueID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnCollectFine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpFinePayments;
        private System.Windows.Forms.DataGridView dgvFinePayments;
    }
}