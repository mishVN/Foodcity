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
    public partial class signoffbc : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public signoffbc()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            backoffice bc = new backoffice();
            bc.Show();
            this.Hide();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Please fill in both username and password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();

                string query = "SELECT * FROM [tem_login] WHERE user_name = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();

                            string delete = "DELETE FROM [tem_login] WHERE user_name = @UserName";
                            using (SqlCommand deleteCmd = new SqlCommand(delete, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@UserName", txtusername.Text.Trim());

                                int rowsAffected = deleteCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Successfully signed off.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    home h = new home();
                                    h.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Error signing off. User might already be signed off.", "Signoff Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
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

                butlogin.PerformClick();
            }
        }
    }
    
}
