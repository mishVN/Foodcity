using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class stockadd : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;
        public stockadd()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM [stock] WHERE item_code = @code";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@code", txtcode.Text.Trim());

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {


                                    string itemName = reader.IsDBNull(reader.GetOrdinal("item_name")) ? string.Empty : reader["item_name"].ToString();
                                    string suplier = reader.IsDBNull(reader.GetOrdinal("suplier")) ? string.Empty : reader["suplier"].ToString();
                                    int quantity = reader.IsDBNull(reader.GetOrdinal("quantity")) ? 0 : Convert.ToInt32(reader["quantity"]);



                                    txtname.Text = itemName;
                                    txtsuplier.Text = suplier;
                                    lblavailable.Text = quantity.ToString();

                                    txtquntity.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("No item found with the given code.");
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

        private void butadd_Click(object sender, EventArgs e)
        {
            int qnty;
            if (!int.TryParse(lblavailable.Text, out qnty))
            {
                MessageBox.Show("Invalid available quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newqnty;
            if (!int.TryParse(txtquntity.Text, out newqnty))
            {
                MessageBox.Show("Please enter a valid quantity.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newstock = qnty + newqnty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = @"UPDATE [stock] 
                         SET quantity = @quantity 
                         WHERE item_code = @item_code";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", newstock);
                        cmd.Parameters.AddWithValue("@item_code", txtcode.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblavailable.Text = newstock.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No item found with the provided code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtquntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                butadd.PerformClick();
            }
        }

    }
}
