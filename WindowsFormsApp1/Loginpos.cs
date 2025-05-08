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
    public partial class Loginpos : Form
    {

        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public Loginpos()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();

                
                if(txtusername.Text==" " || txtpassword.Text == "")
                {
                    MessageBox.Show("Please Fill Blanks", "Empty Username Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "SELECT * FROM [user] WHERE user_name = @username AND user_password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        using (SqlConnection conn = new SqlConnection(connstring))
                        {
                            conn.Open();

                            string insert = @"INSERT INTO [tem_login] (user_name, password,system) VALUES (@user_name, @password,'pos')";

                            using (SqlCommand cmd1 = new SqlCommand(insert, conn))
                            {
                               
                                cmd1.Parameters.AddWithValue("@user_name", txtusername.Text.Trim());
                                cmd1.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                                int rowsAffected = cmd1.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    pos ps = new pos();
                                    ps.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("No rows were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        

                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
