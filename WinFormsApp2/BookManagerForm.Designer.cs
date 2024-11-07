namespace WinFormsApp1
{
    partial class BookManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            lblConnectionStatus = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpPublicationDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            membershipId = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            memberId = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Location = new Point(12, 20);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(0, 20);
            lblConnectionStatus.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First name";
            txtFirstName.Size = new Size(200, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last name";
            txtLastName.Size = new Size(200, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 175);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 5;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Location = new Point(0, 0);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(200, 27);
            dtpPublicationDate.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(100, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(280, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // membershipId
            // 
            membershipId.FormattingEnabled = true;
            membershipId.Location = new Point(12, 237);
            membershipId.Name = "membershipId";
            membershipId.Size = new Size(200, 28);
            membershipId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 214);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 14;
            label1.Text = "Membership";
            // 
            // label2
            // 
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // memberId
            // 
            memberId.Location = new Point(12, 43);
            memberId.Name = "memberId";
            memberId.Size = new Size(200, 28);
            memberId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 15;
            label3.Click += label3_Click;
            // 
            // BookManagerForm
            // 
            ClientSize = new Size(400, 350);
            Controls.Add(label2);
            Controls.Add(memberId);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(membershipId);
            Controls.Add(lblConnectionStatus);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Name = "BookManagerForm";
            Text = "Member Manager";
            Load += BookManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox membershipId;
        private Label label1;
        private Label label2;
        private ComboBox memberId;
        private Label label3;
    }
}
