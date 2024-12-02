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
    public partial class customerScreen : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Data
        public List<Customer> Customers;

        public customerScreen()
        {
            InitializeComponent();

            Customers = RetrieveCustomers();

            EmpDataView.AutoGenerateColumns = false;
            EmpDataView.DataSource = Customers;
            addAttributeColoumns();
            AddEditButtonColumn();
            EmpDataView.CellContentClick += EmpDataView_CellContentClick;
        }

        // Data Source
        private List<Customer>? RetrieveCustomers()
        {
            var customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String nameQuery = "SELECT * FROM Customer";
                using (SqlCommand cmd = new SqlCommand(nameQuery, conn))
                {

                    try
                    {
                        SqlDataReader myReader = cmd.ExecuteReader();

                        while (myReader.Read())
                        {
                            customers.Add(new Customer()
                            {
                                firstName = myReader.GetString(1),
                                lastName = myReader.GetString(2),
                                email = myReader.GetString(8),
                                accountNumber = myReader.GetInt32(7),
                                CreationDate = myReader.GetDateTime(12)
                            });

                        }

                        myReader.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            return customers;
        }

        // Add certain attribute coloumns manually

        private void addAttributeColoumns()
        {
            //Manually adding coloumns

            EmpDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "firstName", // Match the property name in the Customer class
            });

            EmpDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "lastName", // Match the property name in the Customer class
            });

            EmpDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "email", // Match the property name in the Customer class
            });

            EmpDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Address",
                DataPropertyName = "address", // Match the property name in the Customer class
            });

            EmpDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Account Number",
                DataPropertyName = "accountNumber", // Match the property name in the Customer class
            });
        }

        // Add a button column for editing
        private void AddEditButtonColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();

            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            EmpDataView.Columns.Add(editButtonColumn);
        }

        // Handle the click event for the Edit button
        private void EmpDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && EmpDataView.Columns[e.ColumnIndex].Name == "Edit")
            {
                Customer selectedCustomer = (Customer)EmpDataView.Rows[e.RowIndex].DataBoundItem;
                SwitchToScreen(new editCustomer(selectedCustomer));
            }
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

        private void customerScreen_Load(object sender, EventArgs e)
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

        // Body Buttons

        private void addCustomer_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new addCustomer());
        }
    }
}
