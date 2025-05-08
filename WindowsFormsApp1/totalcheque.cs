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

namespace WindowsFormsApp1
{
    public partial class totalcheque : Form
    {
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";

        public totalcheque()
        {
            InitializeComponent();
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dateTimePickerstart.Value.Date;
                DateTime endDate = dateTimePickerend.Value.Date;

                
                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string query = "SELECT dbo.CalculateTotalChequeValue(@StartDate, @EndDate) AS TotalChequeValue";

                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        
                        object result = cmd.ExecuteScalar();

                        
                        if (result != null && decimal.TryParse(result.ToString(), out decimal totalValue))
                        {
                            lbltotal.Text = totalValue.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No cheque records found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
