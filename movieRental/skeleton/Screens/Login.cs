using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using movieRental;
using System.Drawing.Text; 
using System.Runtime.InteropServices; 

namespace skeleton
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public int AccountID = default;
        public string? UserName = default;
        public string? UserType = default;

        // Custom Fonts
        private Font outfitFontS30Bold;
        private Font outfitFontS14Bold;
        private Font outfitFontS12Bold;

        private Font outfitFontS14;
        private Font outfitFontS12;

        public Login()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection String not found");
            }
            InitializeComponent();

            //LoadCustomFont();
            //ApplyFonts();
        }

        //Custom Fonts
        private void LoadCustomFont()
        {
            PrivateFontCollection pfcOutfit = new PrivateFontCollection();
            string outfitFontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Outfit-VariableFont_wght.ttf");
            pfcOutfit.AddFontFile(outfitFontPath);

            outfitFontS30Bold = new Font(pfcOutfit.Families[0], 30f, FontStyle.Bold);
            outfitFontS14Bold = new Font(pfcOutfit.Families[0], 14f, FontStyle.Bold);
            outfitFontS12Bold = new Font(pfcOutfit.Families[0], 12f, FontStyle.Bold);

            outfitFontS14 = new Font(pfcOutfit.Families[0], 14f, FontStyle.Regular);
            outfitFontS12 = new Font(pfcOutfit.Families[0], 12f, FontStyle.Regular);
        }

        private void ApplyFonts()
        {
            titleLabel.Font = outfitFontS30Bold;

            empLabel.Font = outfitFontS30Bold;
            helpLabel.Font = outfitFontS12;

            userLabel.Font = outfitFontS14Bold;
            userName.Font = outfitFontS14;

            passLabel.Font = outfitFontS14Bold;
            passWord.Font = outfitFontS14;

            loginButton.Font = outfitFontS12Bold;
            CreateAccount.Font = outfitFontS12Bold;
        }

        // Switch Screen
        private void SwitchToScreen(UserControl newScreen)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Dispose of existing controls
                foreach (Control control in parentForm.Controls.OfType<UserControl>().ToList())
                {
                    control.Dispose();
                }

                // Clear and add the new screen
                parentForm.Controls.Clear();
                parentForm.Controls.Add(newScreen);
                newScreen.Dock = DockStyle.Fill;
            }
        }

        private void loginClick(object sender, EventArgs e)
        {
            String name = userName.Text;
            string password = passWord.Text;
            if (name == "test")
            {
                SwitchToScreen(new customerScreen());
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String nameQuery = "SELECT * FROM Employee " +
                    "WHERE UserName = " + $"\'{name}\'" +
                    " AND CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE(\'PSWD\', Password)) = " +
                    $"\'{password}\'";
                using (SqlCommand cmd = new SqlCommand(nameQuery, conn))
                {
                    //cmd.Parameters.AddWithValue("@name", name);
                    //cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        SqlDataReader myReader = cmd.ExecuteReader();

                        if (!myReader.Read())
                        {
                            throw new Exception("Invalid login information credentials!");
                        }
                        AccountID = myReader.GetInt32(0);
                        UserName = myReader.GetString(1);
                        UserType = myReader.GetString(3);
                        myReader.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }

                    SwitchToScreen(new customerScreen());

                }
            }
        }


        private void formLoad(object sender, EventArgs e)
        {
            ActiveControl = null;
            helpLabel.Text = "If you are unable to login or you have forgotten your password, either email your manager or contact IT services.";
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            AccountCreation form = new AccountCreation();
            form.ShowDialog();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void helpLabel_Click(object sender, EventArgs e)
        {

        }

        private void empLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userName__TextChanged(object sender, EventArgs e)
        {

        }
    }
}

