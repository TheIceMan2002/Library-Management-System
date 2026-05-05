namespace LibraryManagementSystem
{
    partial class StaffForm
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
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            txtYear = new TextBox();
            txtPublisher = new TextBox();
            txtGenre = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            blank1 = new Label();
            blank = new Label();
            blank2 = new Label();
            blank3 = new Label();
            blank4 = new Label();
            dgvBooks = new DataGridView();
            tabPage2 = new TabPage();
            btnDeleteMember = new Button();
            btnAddMember = new Button();
            txtMemberRole = new TextBox();
            txtMemberPassword = new TextBox();
            txtMemberUsername = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberPhone = new TextBox();
            txtMemberName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMembers = new DataGridView();
            tabPage3 = new TabPage();
            btnReturn = new Button();
            btnCheckout = new Button();
            txtCheckoutCopyID = new TextBox();
            txtCheckoutMemberID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dgvLoans = new DataGridView();
            btnRefreshOverdue = new TabPage();
            button1 = new Button();
            dgvOverdueLoans = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            btnRefreshOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverdueLoans).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(btnRefreshOverdue);
            tabControl1.Location = new Point(26, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(748, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteBook);
            tabPage1.Controls.Add(btnEditBook);
            tabPage1.Controls.Add(btnAddBook);
            tabPage1.Controls.Add(txtYear);
            tabPage1.Controls.Add(txtPublisher);
            tabPage1.Controls.Add(txtGenre);
            tabPage1.Controls.Add(txtISBN);
            tabPage1.Controls.Add(txtTitle);
            tabPage1.Controls.Add(blank1);
            tabPage1.Controls.Add(blank);
            tabPage1.Controls.Add(blank2);
            tabPage1.Controls.Add(blank3);
            tabPage1.Controls.Add(blank4);
            tabPage1.Controls.Add(dgvBooks);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(740, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(586, 307);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(471, 307);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(94, 29);
            btnEditBook.TabIndex = 12;
            btnEditBook.Text = "Edit";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(362, 307);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(520, 234);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 10;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(520, 171);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(125, 27);
            txtPublisher.TabIndex = 9;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(520, 117);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(520, 69);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(125, 27);
            txtISBN.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(520, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 6;
            // 
            // blank1
            // 
            blank1.AutoSize = true;
            blank1.Location = new Point(387, 234);
            blank1.Name = "blank1";
            blank1.Size = new Size(101, 20);
            blank1.TabIndex = 5;
            blank1.Text = "PublishedYear";
            // 
            // blank
            // 
            blank.AutoSize = true;
            blank.Location = new Point(387, 171);
            blank.Name = "blank";
            blank.Size = new Size(69, 20);
            blank.TabIndex = 4;
            blank.Text = "Publisher";
            // 
            // blank2
            // 
            blank2.AutoSize = true;
            blank2.Location = new Point(387, 117);
            blank2.Name = "blank2";
            blank2.Size = new Size(48, 20);
            blank2.TabIndex = 3;
            blank2.Text = "Genre";
            // 
            // blank3
            // 
            blank3.AutoSize = true;
            blank3.Location = new Point(387, 69);
            blank3.Name = "blank3";
            blank3.Size = new Size(41, 20);
            blank3.TabIndex = 2;
            blank3.Text = "ISBN";
            // 
            // blank4
            // 
            blank4.AutoSize = true;
            blank4.Location = new Point(387, 20);
            blank4.Name = "blank4";
            blank4.Size = new Size(38, 20);
            blank4.TabIndex = 1;
            blank4.Text = "Title";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(6, 6);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(350, 371);
            dgvBooks.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteMember);
            tabPage2.Controls.Add(btnAddMember);
            tabPage2.Controls.Add(txtMemberRole);
            tabPage2.Controls.Add(txtMemberPassword);
            tabPage2.Controls.Add(txtMemberUsername);
            tabPage2.Controls.Add(txtMemberEmail);
            tabPage2.Controls.Add(txtMemberPhone);
            tabPage2.Controls.Add(txtMemberName);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dgvMembers);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(740, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Members";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Location = new Point(582, 344);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(122, 29);
            btnDeleteMember.TabIndex = 14;
            btnDeleteMember.Text = "Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(397, 344);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(144, 29);
            btnAddMember.TabIndex = 13;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // txtMemberRole
            // 
            txtMemberRole.Location = new Point(567, 292);
            txtMemberRole.Name = "txtMemberRole";
            txtMemberRole.Size = new Size(125, 27);
            txtMemberRole.TabIndex = 12;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Location = new Point(567, 242);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(125, 27);
            txtMemberPassword.TabIndex = 11;
            // 
            // txtMemberUsername
            // 
            txtMemberUsername.Location = new Point(567, 190);
            txtMemberUsername.Name = "txtMemberUsername";
            txtMemberUsername.Size = new Size(125, 27);
            txtMemberUsername.TabIndex = 10;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(567, 136);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(125, 27);
            txtMemberEmail.TabIndex = 9;
            // 
            // txtMemberPhone
            // 
            txtMemberPhone.Location = new Point(567, 79);
            txtMemberPhone.Name = "txtMemberPhone";
            txtMemberPhone.Size = new Size(125, 27);
            txtMemberPhone.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(567, 24);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(125, 27);
            txtMemberName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 292);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 6;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 242);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 190);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(6, 6);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(385, 381);
            dgvMembers.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnReturn);
            tabPage3.Controls.Add(btnCheckout);
            tabPage3.Controls.Add(txtCheckoutCopyID);
            tabPage3.Controls.Add(txtCheckoutMemberID);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(dgvLoans);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(740, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Checkouts/Returns";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(583, 241);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(365, 241);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtCheckoutCopyID
            // 
            txtCheckoutCopyID.Location = new Point(564, 195);
            txtCheckoutCopyID.Name = "txtCheckoutCopyID";
            txtCheckoutCopyID.Size = new Size(125, 27);
            txtCheckoutCopyID.TabIndex = 4;
            // 
            // txtCheckoutMemberID
            // 
            txtCheckoutMemberID.Location = new Point(365, 195);
            txtCheckoutMemberID.Name = "txtCheckoutMemberID";
            txtCheckoutMemberID.Size = new Size(125, 27);
            txtCheckoutMemberID.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 172);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 2;
            label8.Text = "CopyID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 172);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 1;
            label7.Text = "MemberID";
            // 
            // dgvLoans
            // 
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Location = new Point(3, 3);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.Size = new Size(307, 387);
            dgvLoans.TabIndex = 0;
            // 
            // btnRefreshOverdue
            // 
            btnRefreshOverdue.Controls.Add(button1);
            btnRefreshOverdue.Controls.Add(dgvOverdueLoans);
            btnRefreshOverdue.Location = new Point(4, 29);
            btnRefreshOverdue.Name = "btnRefreshOverdue";
            btnRefreshOverdue.Size = new Size(740, 393);
            btnRefreshOverdue.TabIndex = 3;
            btnRefreshOverdue.Text = "Overdue Loans";
            btnRefreshOverdue.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(532, 172);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRefreshOverdue_Click;
            // 
            // dgvOverdueLoans
            // 
            dgvOverdueLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverdueLoans.Location = new Point(11, 11);
            dgvOverdueLoans.Name = "dgvOverdueLoans";
            dgvOverdueLoans.RowHeadersWidth = 51;
            dgvOverdueLoans.Size = new Size(399, 367);
            dgvOverdueLoans.TabIndex = 0;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "StaffForm";
            Text = "Library Mangement System";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            btnRefreshOverdue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOverdueLoans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage btnRefreshOverdue;
        private DataGridView dgvBooks;
        private Label blank;
        private Label blank2;
        private Label blank3;
        private Label blank4;
        private Label blank1;
        private TextBox txtYear;
        private TextBox txtPublisher;
        private TextBox txtGenre;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private Button btnDeleteBook;
        private Button btnEditBook;
        private Button btnAddBook;
        private DataGridView dgvMembers;
        private Button btnAddMember;
        private TextBox txtMemberRole;
        private TextBox txtMemberPassword;
        private TextBox txtMemberUsername;
        private TextBox txtMemberEmail;
        private TextBox txtMemberPhone;
        private TextBox txtMemberName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDeleteMember;
        private DataGridView dgvLoans;
        private TextBox txtCheckoutCopyID;
        private TextBox txtCheckoutMemberID;
        private Label label8;
        private Label label7;
        private Button btnReturn;
        private Button btnCheckout;
        private Button button1;
        private DataGridView dgvOverdueLoans;
    }
}