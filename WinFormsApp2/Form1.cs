using System;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMember();
        }

        private void LoadMember()
        {
            var context = new AppDbContext();
            var memberService = new MemberService(context);

            try
            {
                DataTable dataTable = new DataTable();

                // Define columns in DataTable (adjust columns based on your Member model)
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("First name", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                // Add more columns as needed

                // Get all members
                var members = memberService.GetAllMembers();

                // Populate DataTable with member data
                foreach (var member in members)
                {
                    dataTable.Rows.Add(member.Id, member.FirstName, member.Email);
                }

                // Bind the DataTable to the DataGridView
                dgvBooks.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
          
                try
                {
                    // MySqlCommand cmd = new MySqlCommand(query, connection);
                    // cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    // MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    // DataTable dataTable = new DataTable();
                    // adapter.Fill(dataTable);
                    // dgvBooks.DataSource = dataTable;
                    MessageBox.Show($"Searching: {searchTerm}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
        }

        private void btnBookManager_Click(object sender, EventArgs e)
        {
            // Ouvre la fenêtre de gestion des livres
            BookManagerForm bookManagerForm = new BookManagerForm();
            bookManagerForm.Show();
            this.Hide(); // Cacher la fenêtre d'accueil
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
