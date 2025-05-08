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
    public partial class showcheque : Form
    {
        
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public showcheque()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadChequeDetails();
        }

        private void LoadChequeDetails()
        {
            try
            {
                
                string query = "SELECT * FROM LiveDateChequeDetail";

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

        private void showcheque_Load(object sender, EventArgs e)
        {
            LoadChequeDetails();
        }
    }
}
