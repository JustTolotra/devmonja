using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            LoadAllBooks();
        }

        private void LoadAllBooks()
        {
            string query = "SELECT * FROM books";
            string connectionString = "Server=localhost;Database=gestionbibli;User ID=root;Password=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvBooks.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            string query = "SELECT * FROM books WHERE name LIKE @searchTerm OR author LIKE @searchTerm";
            string connectionString = "Server=localhost;Database=gestionbibli;User ID=root;Password=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvBooks.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
