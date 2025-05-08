using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class totalsale : Form
    {
        
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";

        public totalsale()
        {
            InitializeComponent();
        }

        private void butload_Click(object sender, EventArgs e)
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

                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("dbo.GetSalesReport", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (dataTable.Rows.Count > 0)
                            {
                                MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No records found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalsale_Load(object sender, EventArgs e)
        {
            
            dateTimePickerstart.Value = DateTime.Today.AddDays(-30); 
            dateTimePickerend.Value = DateTime.Today;
        }
    }
}
