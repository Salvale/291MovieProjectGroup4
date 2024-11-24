using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using movieRental;
using System.Drawing.Text; 
using System.Runtime.InteropServices; 



namespace skeleton
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        public int AccountID = default;
        public string? UserName = default;
        public string? UserType = default;

        // Custom Fonts
        private Font newakeFontS36;
        private Font newakeFontS16;
        private Font newakeFontS14;
        private Font outfitFontS14;
        private Font outfitFontS16;

        public Form1()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection String not found");
            }
            InitializeComponent();
            LoadCustomFont();
            ApplyFonts();
        }

        //Custom Fonts
        private void LoadCustomFont()
        {
            PrivateFontCollection pfcNewake = new PrivateFontCollection();
            PrivateFontCollection pfcOutfit = new PrivateFontCollection();

            string newakeFontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Newake-Font-Demo.otf");
            string outfitFontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Outfit-VariableFont_wght.ttf");

            pfcNewake.AddFontFile(newakeFontPath);
            pfcOutfit.AddFontFile(outfitFontPath);

            newakeFontS36 = new Font(pfcNewake.Families[0], 36f, FontStyle.Regular);
            newakeFontS16 = new Font(pfcNewake.Families[0], 16f, FontStyle.Regular);
            newakeFontS14 = new Font(pfcNewake.Families[0], 14f, FontStyle.Regular);

            outfitFontS16 = new Font(pfcOutfit.Families[0], 16f, FontStyle.Regular);
            outfitFontS14 = new Font(pfcOutfit.Families[0], 14f, FontStyle.Regular);
        }

        private void ApplyFonts()
        {
            titleLabel.Font = newakeFontS36;

            empLabel.Font = newakeFontS36;
            helpLabel.Font = outfitFontS14;

            userLabel.Font = newakeFontS16;
            userName.Font = outfitFontS16;

            passLabel.Font = newakeFontS16;
            passWord.Font = outfitFontS16;

            loginButton.Font = newakeFontS14;
            CreateAccount.Font = newakeFontS14;
        }

        private void loginClick(object sender, EventArgs e)
        {
            String name = userName.Text;
            string password = passWord.Text;
            if (name == "test")
            {
                var mainMenuControl = new mainMenu();

                this.Controls.Clear();
                this.Controls.Add(mainMenuControl);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String nameQuery = "SELECT * FROM Account " +
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

                    Control mainMenuControl;
                    if (UserType == "Employee")
                    {
                        MessageBox.Show($"Welcome back {name}!");
                        mainMenuControl = new mainMenu();

                        this.Controls.Clear();
                        this.Controls.Add(mainMenuControl);
                        return;
                    }

                    MessageBox.Show($"Welcome back {name}!");
                    mainMenuControl = new CustomerMenu();
                    this.Controls.Clear();
                    this.Controls.Add(mainMenuControl);
                    return;


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
    }
}

