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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace movieRental
{
    public partial class addCustomer : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        // Data
        public List<Movie> Movies;

        public addCustomer()
        {
            InitializeComponent();
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

        private void addCustomer_Load(object sender, EventArgs e)
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

        private void addCustomerClick(object sender, EventArgs e)
        {
            if (fieldValidation())
            {

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string accountNumber = "2552221";
                        string creditCardNum = "4545";
                        string creditCardExp = "2022";
                        string creditCardCvv = "455";

                        string query = "INSERT INTO Customer (FirstName, FamilyName, Address, City, Province, PostalCode, AccountNumber, EmailAddress, CreditCardNum, CreditCardExp, CreditCardCvv) VALUES (@firstName, @lastName, @address, @city, @province, @postalCode, @accountNumber, @emailAddress, @creditCardNum, @creditCardExp, @creditCardCvv)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@firstName", FirstNameInput.Text);
                            command.Parameters.AddWithValue("@lastName", LastNameInput.Text);
                            command.Parameters.AddWithValue("@address", AddressInput.Text);
                            command.Parameters.AddWithValue("@city", CityInput.Text);
                            command.Parameters.AddWithValue("@province", ProvinceInput.Text);
                            command.Parameters.AddWithValue("@postalCode", PostalCodeInput.Text);
                            command.Parameters.AddWithValue("@accountNumber", accountNumber);
                            command.Parameters.AddWithValue("@emailAddress", EmailInput.Text);
                            command.Parameters.AddWithValue("@creditCardNum", creditCardNum);
                            command.Parameters.AddWithValue("@creditCardExp", creditCardExp);
                            command.Parameters.AddWithValue("@creditCardCvv", creditCardCvv);


                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFormFields();
                            }
                            else
                            {
                                MessageBox.Show("No records were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private bool fieldValidation()
        {
            if (!string.IsNullOrEmpty(FirstNameInput.Text) &&
                !string.IsNullOrEmpty(LastNameInput.Text) &&
                !string.IsNullOrEmpty(EmailInput.Text))
            {
                return true;
            }

            return false;
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
    }
}
