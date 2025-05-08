using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class lawstock : Form
    {
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";

        public lawstock()
        {
            InitializeComponent();
        }

        private void lawstock_Load(object sender, EventArgs e)
        {
            LoadLowStockItems();

        }
        private void LoadLowStockItems()
        {
            try
            {
                
                string query = "SELECT * FROM dbo.LowStockItems";

                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
