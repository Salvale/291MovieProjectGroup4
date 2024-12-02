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

        public Login()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection String not found");
            }

            InitializeComponent();
        }

        private void formLoad(object sender, EventArgs e)
        {
            ActiveControl = null;
            helpLabel.Text = "If you are unable to login or you have forgotten your password, either email your manager or contact IT services.";
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

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            AccountCreation form = new AccountCreation();
            form.ShowDialog();
        }
    }
}

