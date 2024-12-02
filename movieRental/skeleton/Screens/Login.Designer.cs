namespace skeleton
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userLabel = new Label();
            passLabel = new Label();
            titleLabel = new Label();
            empLabel = new Label();
            helpLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            userName = new CustomControls.RoundedTextBox.RoundedTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            passWord = new CustomControls.RoundedTextBox.RoundedTextBox();
            loginButton = new Button();
            CreateAccount = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 15.7310925F);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(37, 16);
            userLabel.Margin = new Padding(0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(467, 30);
            userLabel.TabIndex = 2;
            userLabel.Text = "Username";
            // 
            // passLabel
            // 
            passLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Microsoft Sans Serif", 15.7310925F);
            passLabel.ForeColor = Color.White;
            passLabel.Location = new Point(37, 16);
            passLabel.Margin = new Padding(0);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(467, 30);
            passLabel.TabIndex = 3;
            passLabel.Text = "Password";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 32.0672226F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(134, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(444, 195);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Movie Rental";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // empLabel
            // 
            empLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            empLabel.AutoSize = true;
            empLabel.Font = new Font("Microsoft Sans Serif", 32.0672226F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empLabel.ForeColor = Color.White;
            empLabel.ImageAlign = ContentAlignment.MiddleLeft;
            empLabel.Location = new Point(3, 146);
            empLabel.Name = "empLabel";
            empLabel.Size = new Size(405, 61);
            empLabel.TabIndex = 6;
            empLabel.Text = "Employee Login";
            // 
            // helpLabel
            // 
            helpLabel.AutoSize = true;
            helpLabel.Font = new Font("Microsoft Sans Serif", 12.1008387F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpLabel.ForeColor = Color.White;
            helpLabel.Location = new Point(3, 228);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(49, 25);
            helpLabel.TabIndex = 7;
            helpLabel.Text = "help";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 3, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1305, 804);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(helpLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(empLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(68, 204);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel2.Size = new Size(581, 436);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(titleLabel, 1, 0);
            tableLayoutPanel6.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel6.Location = new Point(68, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(581, 195);
            tableLayoutPanel6.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = movieRental.Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(CreateAccount, 0, 3);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel5.Controls.Add(loginButton, 0, 2);
            tableLayoutPanel5.Location = new Point(720, 204);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel5.Size = new Size(516, 436);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel3.Controls.Add(userName, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(510, 137);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(userLabel, 1, 0);
            tableLayoutPanel7.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(504, 62);
            tableLayoutPanel7.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = movieRental.Properties.Resources.username;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userName.BackColor = Color.FromArgb(25, 26, 63);
            userName.BorderColor = Color.FromArgb(25, 26, 63);
            userName.BorderFocusColor = Color.FromArgb(84, 80, 164);
            userName.BorderRadius = 25;
            userName.BorderSize = 2;
            userName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.White;
            userName.Location = new Point(0, 77);
            userName.Margin = new Padding(0);
            userName.Multiline = false;
            userName.Name = "userName";
            userName.Padding = new Padding(20, 15, 20, 15);
            userName.PasswordChar = false;
            userName.PlaceholderColor = Color.DarkGray;
            userName.PlaceholderText = "";
            userName.Size = new Size(510, 51);
            userName.TabIndex = 18;
            userName.UnderlinedStyle = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel4.Controls.Add(passWord, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 146);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(510, 137);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.AutoSize = true;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(passLabel, 1, 0);
            tableLayoutPanel8.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(504, 62);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = movieRental.Properties.Resources.password;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // passWord
            // 
            passWord.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passWord.BackColor = Color.FromArgb(25, 26, 63);
            passWord.BorderColor = Color.FromArgb(25, 26, 63);
            passWord.BorderFocusColor = Color.FromArgb(84, 80, 164);
            passWord.BorderRadius = 25;
            passWord.BorderSize = 2;
            passWord.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passWord.ForeColor = Color.White;
            passWord.Location = new Point(0, 77);
            passWord.Margin = new Padding(0);
            passWord.Multiline = false;
            passWord.Name = "passWord";
            passWord.Padding = new Padding(20, 15, 20, 15);
            passWord.PasswordChar = true;
            passWord.PlaceholderColor = Color.DarkGray;
            passWord.PlaceholderText = "********";
            passWord.Size = new Size(510, 51);
            passWord.TabIndex = 18;
            passWord.UnderlinedStyle = false;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.FromArgb(84, 80, 164);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(3, 298);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(510, 50);
            loginButton.TabIndex = 17;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginClick;
            // 
            // CreateAccount
            // 
            CreateAccount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CreateAccount.BackColor = Color.FromArgb(84, 80, 164);
            CreateAccount.FlatAppearance.BorderSize = 0;
            CreateAccount.FlatStyle = FlatStyle.Flat;
            CreateAccount.ForeColor = Color.White;
            CreateAccount.Location = new Point(3, 373);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(510, 50);
            CreateAccount.TabIndex = 18;
            CreateAccount.Text = "Create an Account";
            CreateAccount.UseVisualStyleBackColor = false;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 44, 91);
            ClientSize = new Size(1305, 800);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.FromArgb(118, 119, 141);
            Name = "Login";
            Text = "Movie Rental System";
            Load += formLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label userLabel;
        private Label passLabel;
        private Label titleLabel;
        private Label empLabel;
        private Label helpLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox3;
        private CustomControls.RoundedTextBox.RoundedTextBox userName;
        private CustomControls.RoundedTextBox.RoundedTextBox passWord;
        private Button CreateAccount;
        private Button loginButton;
    }
}
