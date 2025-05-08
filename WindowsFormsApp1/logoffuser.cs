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
    public partial class logoffuser : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public logoffuser()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();


                if (txtuser.Text == " " || txtpassword.Text == "")
                {
                    MessageBox.Show("Please Fill Blanks", "Empty Username Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "SELECT * FROM [tem_login] WHERE user_name = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        using (SqlConnection conn = new SqlConnection(connstring))
                        {
                            conn.Open();

                            string insert = @"DELETE FROM [tem_login] WHERE user_name=@user_name";

                            using (SqlCommand cmd1 = new SqlCommand(insert, conn))
                            {

                                cmd1.Parameters.AddWithValue("@user_name", txtuser.Text.Trim());
                                

                                int rowsAffected = cmd1.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("SuccessFull Logout", "LogOut", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                        MessageBox.Show("This Account Not Sign in system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
