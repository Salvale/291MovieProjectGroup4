using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Configuration;
using System.Drawing.Text;

namespace movieRental
{
    public partial class editCustomer : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        // Data
        public List<Movie> Movies;

        private Customer customerToEdit;

        public editCustomer(Customer customer)
        {
            InitializeComponent();

            this.customerToEdit = customer;

            loadInfo();
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

        private void editCustomer_Load(object sender, EventArgs e)
        {

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new customerScreen());
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new moviesScreen());
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new rentalScreen());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new reportScreen());
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesClick(object sender, EventArgs e)
        {
            int x = 1;
        }

        private void ClearFormFields()
        {
            FirstNameInput.Text = string.Empty;
            LastNameInput.Text = string.Empty;
            AddressInput.Text = string.Empty;
            CityInput.Text = string.Empty;
            ProvinceInput.Text = string.Empty;
            PostalCodeInput.Text = string.Empty;
            EmailInput.Text = string.Empty;
        }

        private void loadInfo()
        {
            try
            {
                Customer? customer = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Customer WHERE {customerToEdit.accountNumber} = AccountNumber";
                    MessageBox.Show($"{customerToEdit.accountNumber}");
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        try
                        {
                            SqlDataReader myReader = cmd.ExecuteReader();

                            if (myReader.Read())
                            {
                                customer = new Customer()
                                {
                                    
                                    firstName = myReader.GetString(1),
                                    lastName = myReader.GetString(2),
                                    address = myReader.IsDBNull(3) ? "" : myReader.GetString(3), // Check for NULL
                                    city = myReader.IsDBNull(4) ? "" : myReader.GetString(4),    // Check for NULL
                                    province = myReader.IsDBNull(5) ? "" : myReader.GetString(5),// Check for NULL
                                    postalCode = myReader.IsDBNull(6) ? "" : myReader.GetString(6), // Check for NULL
                                    email = myReader.GetString(8),
                                    CreationDate = myReader.GetDateTime(12)
                                };


                            }


                            myReader.Close();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("EXCEPTION");
                            MessageBox.Show(exception.Message);
                        }
                    }

                    FirstNameInput.Text = customer.firstName;
                    LastNameInput.Text = customer.lastName;
                    AddressInput.Text = customer.address;
                    CityInput.Text = customer.city;
                    ProvinceInput.Text = customer.province;
                    PostalCodeInput.Text = customer.postalCode;
                    EmailInput.Text = customer.email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
