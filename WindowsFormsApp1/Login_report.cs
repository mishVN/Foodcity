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
    public partial class Login_report : Form
    {
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";

        public Login_report()
        {
            InitializeComponent();
        }

        private void Login_report_Load(object sender, EventArgs e)
        {
            LoadLoginDetails();
        }

        private void LoadLoginDetails()
        {
            try
            {
              
                string query = "SELECT username, system, date FROM [login_details]";
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

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadLoginDetails();
        }
    }

}
