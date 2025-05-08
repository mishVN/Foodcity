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
using System.Xml.Linq;


namespace WindowsFormsApp1
{
    public partial class Account : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;
        public Account()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM [user] WHERE user_id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtuserid.Text.Trim());

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    string username = reader.IsDBNull(reader.GetOrdinal("user_name")) ? string.Empty : reader["user_name"].ToString();
                                    string user_password = reader.IsDBNull(reader.GetOrdinal("user_password")) ? string.Empty : reader["user_password"].ToString();
                                    string account_type = reader.IsDBNull(reader.GetOrdinal("account_type")) ? string.Empty : reader["account_type"].ToString();

                                    txtusername.Text = username;
                                    txtpassword.Text = user_password;
                                    txtaccounttype.Text = account_type;

                                }
                                else
                                {
                                    MessageBox.Show("No Account found with the given Id.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuserid.Text))
            {
                MessageBox.Show("Please enter the Account ID to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    // Corrected UPDATE query syntax
                    string query = @"UPDATE [user] 
                             SET user_name = @user_name, 
                                 user_password = @user_password, 
                                 account_type = @account_type
                             WHERE user_id = @user_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters for the query
                        cmd.Parameters.AddWithValue("@user_name", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@user_password", txtpassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@account_type", txtaccounttype.Text.Trim());
                        cmd.Parameters.AddWithValue("@user_id", int.Parse(txtuserid.Text.Trim())); // Assuming user_id is an integer

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No account found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void butdelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuserid.Text))
            {
                MessageBox.Show("Please enter the Account ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    // DELETE query for MSSQL
                    string query = "DELETE FROM [user] WHERE user_id = @user_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Parse user_id to an integer (assuming it is a numeric column in the database)
                        cmd.Parameters.AddWithValue("@user_id", int.Parse(txtuserid.Text.Trim()));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No account found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
