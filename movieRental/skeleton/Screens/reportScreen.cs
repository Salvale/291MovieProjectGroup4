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
    public partial class reportScreen : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        // Data

        // Custom Fonts

        public reportScreen()
        {
            InitializeComponent();

        }

        private void reportScreen_Load(object sender, EventArgs e)
        {

        }

        // Data Source

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

        // Screen Buttons
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
        private void recommendMovieButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new recommendedMovie());
        }

        private void grossingMovieButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new grossingMovies());
        }

        private void prolificEmployeeButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new prolificEmployee());
        }

        private void biggestFanButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new biggestFan());
        }

        private void highestMovieGenreButton_Click(object sender, EventArgs e)
        {
            SwitchToScreen(new highestRatedGenreMovie());
        }
    }
}
