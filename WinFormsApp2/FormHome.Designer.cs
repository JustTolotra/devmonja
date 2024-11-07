namespace WinFormsApp1
{
    partial class FormHome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBooks;

        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for a book...";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 80);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(600, 200);
            dgvBooks.TabIndex = 2;
            // 
            // FormHome
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "FormHome";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
