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
    public partial class addcheque : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public addcheque()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtvalue.Text) || string.IsNullOrWhiteSpace(txtno.Text))
            {
                MessageBox.Show("Please fill in Blanks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = @"INSERT INTO [cheque_detail] (cheque_number, cheque_owner , cheque_value,cheque_date) VALUES (@number, @name,@value,@date)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("number", txtno.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                        cmd.Parameters.AddWithValue("@value", txtvalue.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);




                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
