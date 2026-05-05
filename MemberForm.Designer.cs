namespace LibraryManagementSystem
{
    partial class MemberForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            txtReserveMemberID = new TextBox();
            btnReserve = new Button();
            dgvCatalog = new DataGridView();
            tabPage2 = new TabPage();
            btnRefreshAccount = new Button();
            label2 = new Label();
            txtMyAccountMemberID = new TextBox();
            dgvMyFines = new DataGridView();
            dgvMyLoans = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyFines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyLoans).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(676, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtReserveMemberID);
            tabPage1.Controls.Add(btnReserve);
            tabPage1.Controls.Add(dgvCatalog);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(668, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Catalog";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 214);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "MemberID";
            // 
            // txtReserveMemberID
            // 
            txtReserveMemberID.Location = new Point(465, 259);
            txtReserveMemberID.Name = "txtReserveMemberID";
            txtReserveMemberID.Size = new Size(125, 27);
            txtReserveMemberID.TabIndex = 2;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(477, 315);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(94, 29);
            btnReserve.TabIndex = 1;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // dgvCatalog
            // 
            dgvCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalog.Location = new Point(6, 6);
            dgvCatalog.Name = "dgvCatalog";
            dgvCatalog.RowHeadersWidth = 51;
            dgvCatalog.Size = new Size(381, 381);
            dgvCatalog.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRefreshAccount);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtMyAccountMemberID);
            tabPage2.Controls.Add(dgvMyFines);
            tabPage2.Controls.Add(dgvMyLoans);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(668, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "My Account";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAccount
            // 
            btnRefreshAccount.Location = new Point(273, 325);
            btnRefreshAccount.Name = "btnRefreshAccount";
            btnRefreshAccount.Size = new Size(94, 29);
            btnRefreshAccount.TabIndex = 4;
            btnRefreshAccount.Text = "Refresh";
            btnRefreshAccount.UseVisualStyleBackColor = true;
            btnRefreshAccount.Click += btnRefreshAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 219);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "MemberID";
            // 
            // txtMyAccountMemberID
            // 
            txtMyAccountMemberID.Location = new Point(263, 262);
            txtMyAccountMemberID.Name = "txtMyAccountMemberID";
            txtMyAccountMemberID.Size = new Size(125, 27);
            txtMyAccountMemberID.TabIndex = 2;
            // 
            // dgvMyFines
            // 
            dgvMyFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyFines.Location = new Point(349, 6);
            dgvMyFines.Name = "dgvMyFines";
            dgvMyFines.RowHeadersWidth = 51;
            dgvMyFines.Size = new Size(300, 188);
            dgvMyFines.TabIndex = 1;
            // 
            // dgvMyLoans
            // 
            dgvMyLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyLoans.Location = new Point(6, 6);
            dgvMyLoans.Name = "dgvMyLoans";
            dgvMyLoans.RowHeadersWidth = 51;
            dgvMyLoans.Size = new Size(300, 188);
            dgvMyLoans.TabIndex = 0;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MemberForm";
            Text = "Library Management System";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalog).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyFines).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnReserve;
        private DataGridView dgvCatalog;
        private Label label1;
        private TextBox txtReserveMemberID;
        private TextBox txtMyAccountMemberID;
        private DataGridView dgvMyFines;
        private DataGridView dgvMyLoans;
        private Label label2;
        private Button btnRefreshAccount;
    }
}