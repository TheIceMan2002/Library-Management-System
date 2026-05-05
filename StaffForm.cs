using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            LoadBooks();
            LoadMembers();
        }

        private void LoadBooks()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT BookID, Title, ISBN, Genre, Publisher, PublishedYear FROM Books";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Books (Title, ISBN, Genre, Publisher, PublishedYear) VALUES (@Title, @ISBN, @Genre, @Publisher, @Year)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                    cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0) return;
            int bookID = (int)dgvBooks.SelectedRows[0].Cells["BookID"].Value;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Books WHERE BookID = @BookID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadBooks();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0) return;
            int bookID = (int)dgvBooks.SelectedRows[0].Cells["BookID"].Value;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Books SET Title=@Title, ISBN=@ISBN, Genre=@Genre, Publisher=@Publisher, PublishedYear=@Year WHERE BookID=@BookID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", blank4.Text);
                    cmd.Parameters.AddWithValue("@ISBN", blank3.Text);
                    cmd.Parameters.AddWithValue("@Genre", blank2.Text);
                    cmd.Parameters.AddWithValue("@Publisher", blank.Text);
                    cmd.Parameters.AddWithValue("@Year", int.Parse(blank1.Text));
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadBooks();
        }

        private void LoadMembers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MemberID, MemberName, MemberPhone, MemberEmail, MemberUsername, Role FROM Members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Members (MemberName, MemberPhone, MemberEmail, MemberUsername, MemberPassword, RegistrationDate, Role) VALUES (@Name, @Phone, @Email, @Username, @Password, @Date, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtMemberName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtMemberPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMemberEmail.Text);
                    cmd.Parameters.AddWithValue("@Username", txtMemberUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtMemberPassword.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Role", txtMemberRole.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadMembers();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0) return;
            int memberID = (int)dgvMembers.SelectedRows[0].Cells["MemberID"].Value;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Members WHERE MemberID = @MemberID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadMembers();
        }

        private void LoadLoans()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT LoanID, CopyID, MemberID, CheckoutDate, DueDate, ReturnDate FROM Loans";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvLoans.DataSource = dt;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Loans (CopyID, MemberID, CheckoutDate, DueDate) VALUES (@CopyID, @MemberID, @CheckoutDate, @DueDate)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyID", int.Parse(txtCheckoutCopyID.Text));
                    cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtCheckoutMemberID.Text));
                    cmd.Parameters.AddWithValue("@CheckoutDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@DueDate", DateTime.Today.AddDays(14));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadLoans();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvLoans.SelectedRows.Count == 0) return;
            int loanID = (int)dgvLoans.SelectedRows[0].Cells["LoanID"].Value;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "EXEC ProcessReturn @LoanID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanID);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadLoans();
        }

        private void LoadOverdueLoans()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM OverdueLoans";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvOverdueLoans.DataSource = dt;
            }
        }

        private void btnRefreshOverdue_Click(object sender, EventArgs e)
        {
            LoadOverdueLoans();
        }
    }
}