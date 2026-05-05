using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            LoadCatalog();
        }

        private void LoadCatalog()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT b.BookID, b.Title, b.ISBN, b.Genre, b.Publisher, b.PublishedYear, bc.Status FROM Books b JOIN BookCopies bc ON b.BookID = bc.BookID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvCatalog.DataSource = dt;
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dgvCatalog.SelectedRows.Count == 0) return;
            int bookID = (int)dgvCatalog.SelectedRows[0].Cells["BookID"].Value;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Reservations (BookID, MemberID, Status, ReservationDate) VALUES (@BookID, @MemberID, 'Pending', @Date)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtReserveMemberID.Text));
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Reservation placed successfully.");
            LoadCatalog();
        }

        private void btnRefreshAccount_Click(object sender, EventArgs e)
        {
            LoadMyAccount();
        }

        private void LoadMyAccount()
        {
            int memberID = int.Parse(txtMyAccountMemberID.Text);
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string loansQuery = "SELECT LoanID, CopyID, CheckoutDate, DueDate, ReturnDate FROM Loans WHERE MemberID = @MemberID";
                SqlDataAdapter loansAdapter = new SqlDataAdapter(loansQuery, conn);
                loansAdapter.SelectCommand.Parameters.AddWithValue("@MemberID", memberID);
                System.Data.DataTable loansTable = new System.Data.DataTable();
                loansAdapter.Fill(loansTable);
                dgvMyLoans.DataSource = loansTable;

                string finesQuery = "SELECT f.LoanID, f.Amount, f.Status FROM Fines f JOIN Loans l ON f.LoanID = l.LoanID WHERE l.MemberID = @MemberID";
                SqlDataAdapter finesAdapter = new SqlDataAdapter(finesQuery, conn);
                finesAdapter.SelectCommand.Parameters.AddWithValue("@MemberID", memberID);
                System.Data.DataTable finesTable = new System.Data.DataTable();
                finesAdapter.Fill(finesTable);
                dgvMyFines.DataSource = finesTable;
            }
        }
    }
}