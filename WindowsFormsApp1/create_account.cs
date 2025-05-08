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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp1
{
    public partial class create_account : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public create_account()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                txtusername.Focus();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                butcreate.PerformClick();
            }
        }

        private void butcreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) || string.IsNullOrWhiteSpace(txtaccounttype.Text))
            {
                MessageBox.Show("Please fill in both the username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = @"INSERT INTO [user] (user_name, user_password , account_type) VALUES (@user_name, @user_password,@account_type)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@user_name", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@user_password", txtpassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@account_type", txtaccounttype.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
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

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void butcalllastcode_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                    // Use TOP 1 instead of LIMIT for MSSQL
                    string query = "SELECT TOP 1 user_id FROM [user] ORDER BY user_id DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int code = Convert.ToInt32(result);
                            code = code + 1;
                            textBox2.Text = code.ToString();
                        }
                        else
                        {
                            // Handle the case where no rows exist in the table
                            textBox2.Text = "1"; // Default starting user ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
