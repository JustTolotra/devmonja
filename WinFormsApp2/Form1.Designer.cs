namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBookManager;
        private System.Windows.Forms.DataGridView dgvBooks;

        private void InitializeComponent()
        {
            lblConnectionStatus = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnBookManager = new Button();
            dgvBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Location = new Point(12, 50);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(0, 20);
            lblConnectionStatus.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(218, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for a book...";
            txtSearch.Size = new Size(639, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(875, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBookManager
            // 
            btnBookManager.Location = new Point(12, 12);
            btnBookManager.Name = "btnBookManager";
            btnBookManager.Size = new Size(200, 27);
            btnBookManager.TabIndex = 3;
            btnBookManager.Text = "Manage Books";
            btnBookManager.UseVisualStyleBackColor = true;
            btnBookManager.Click += btnBookManager_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 55);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(990, 383);
            dgvBooks.TabIndex = 4;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // Form1
            // 
            ClientSize = new Size(1014, 450);
            Controls.Add(dgvBooks);
            Controls.Add(btnBookManager);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblConnectionStatus);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
