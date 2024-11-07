using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class BookManagerForm : Form
    {
        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string reference = txtFirstName.Text;
            string title = txtLastName.Text;
            string author = txtEmail.Text;
            string edition = txtPhone.Text;

            if (!string.IsNullOrEmpty(reference) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                
                    try
                    {
                       // Miantso service
                        MessageBox.Show("Book added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(memberId.Text);
            if(id == 0)
            {
                MessageBox.Show("Please select an id.");
                return;
            }
            int theMembershipId = Convert.ToInt32(membershipId.Text);
            string reference = txtFirstName.Text;
            string title = txtLastName.Text;
            string author = txtEmail.Text;
            string edition = txtPhone.Text;

            if (!string.IsNullOrEmpty(reference) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                    try
                    {
                    // Miantso service
                        MessageBox.Show("Book updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(memberId.Text);

            if (bookId > 0)
            {

                try
                {
                    MessageBox.Show("Book deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid book ID.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Retour à la page d'accueil
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Close(); // Ferme la fenêtre de gestion des livres
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
