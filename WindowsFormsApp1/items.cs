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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp1
{
    public partial class items : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;
        public items()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

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
                        string query = "SELECT * FROM [item] WHERE item_code = @code";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@code", txtcode.Text.Trim());

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    int barcode = reader.IsDBNull(reader.GetOrdinal("barcode")) ? 0 : Convert.ToInt32(reader["barcode"]);
                                    string itemName = reader.IsDBNull(reader.GetOrdinal("item_name")) ? string.Empty : reader["item_name"].ToString();
                                    string suplier = reader.IsDBNull(reader.GetOrdinal("suplier")) ? string.Empty : reader["suplier"].ToString();
                                    string categary = reader.IsDBNull(reader.GetOrdinal("categary")) ? string.Empty : reader["categary"].ToString();
                                    double cost = reader.IsDBNull(reader.GetOrdinal("cost")) ? 0 : Convert.ToDouble(reader["cost"]);
                                    string minimumprice = reader.IsDBNull(reader.GetOrdinal("min_price")) ? string.Empty : reader["min_price"].ToString();
                                    
                                    double sellingPrice = reader.IsDBNull(reader.GetOrdinal("selling_price")) ? 0 : Convert.ToDouble(reader["selling_price"]);
                                    double wholesaleprice = reader.IsDBNull(reader.GetOrdinal("wholesale_price")) ? 0 : Convert.ToDouble(reader["wholesale_price"]);
                                    double fraction = reader.IsDBNull(reader.GetOrdinal("fraction")) ? 0 : Convert.ToDouble(reader["fraction"]);
                                    int quantity = reader.IsDBNull(reader.GetOrdinal("whole_qty")) ? 0 : Convert.ToInt32(reader["whole_qty"]);


                                    txtbarcode.Text = barcode.ToString();
                                    txtname.Text = itemName;
                                    txtsuplier.Text = suplier;
                                    txtcatogary.Text = categary;
                                    txtcost.Text = cost.ToString();
                                    txtsellingprice.Text = sellingPrice.ToString();
                                    txtquntity.Text = quantity.ToString();
                                    txtminimumprice.Text = minimumprice;
                                    txtfraction.Text = fraction.ToString();
                                    txtwholesaleprice.Text = wholesaleprice.ToString();
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

        private void butsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM [item] WHERE item_code = @code";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", txtcode.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                int barcode = reader.IsDBNull(reader.GetOrdinal("barcode")) ? 0 : Convert.ToInt32(reader["barcode"]);
                                string itemName = reader.IsDBNull(reader.GetOrdinal("item_name")) ? string.Empty : reader["item_name"].ToString();
                                string suplier = reader.IsDBNull(reader.GetOrdinal("suplier")) ? string.Empty : reader["suplier"].ToString();
                                string categary = reader.IsDBNull(reader.GetOrdinal("categary")) ? string.Empty : reader["categary"].ToString();
                                double cost = reader.IsDBNull(reader.GetOrdinal("cost")) ? 0 : Convert.ToDouble(reader["cost"]);
                                double minimumPrice = reader.IsDBNull(reader.GetOrdinal("min_price")) ? 0 : Convert.ToDouble(reader["min_price"]);
                                double sellingPrice = reader.IsDBNull(reader.GetOrdinal("selling_price")) ? 0 : Convert.ToDouble(reader["selling_price"]);
                                double wholesaleprice = reader.IsDBNull(reader.GetOrdinal("wholesale_price")) ? 0 : Convert.ToDouble(reader["wholesale_price"]);
                                double fraction = reader.IsDBNull(reader.GetOrdinal("fraction")) ? 0 : Convert.ToDouble(reader["fraction"]);
                                int quantity = reader.IsDBNull(reader.GetOrdinal("whole_qty")) ? 0 : Convert.ToInt32(reader["whole_qty"]);


                                txtbarcode.Text = barcode.ToString();
                                txtname.Text = itemName;
                                txtsuplier.Text = suplier;
                                txtcatogary.Text = categary;
                                txtcost.Text = cost.ToString();
                                txtsellingprice.Text = sellingPrice.ToString();
                                txtquntity.Text = quantity.ToString();
                                txtminimumprice.Text = minimumPrice.ToString();
                                txtfraction.Text = fraction.ToString();
                                txtwholesaleprice.Text = wholesaleprice.ToString();
                            }
                            else
                            {

                            }
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

        private void butcalllastcode_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                    // Use TOP 1 to get the last item_code in descending order
                    string query = "SELECT TOP 1 item_code FROM [item] ORDER BY item_code DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int code = Convert.ToInt32(result);
                            code = code + 1;
                            txtcode.Text = code.ToString();

                            txtname.Clear();
                            txtsuplier.Clear();
                            txtcatogary.Clear();
                            txtcost.Clear();
                            txtfraction.Clear();
                            txtsellingprice.Clear();
                            txtminimumprice.Clear();
                            txtwholesaleprice.Clear();
                            txtquntity.Clear();
                        }
                        else
                        {
                            // If no rows are found, start with a default code (e.g., 1)
                            txtcode.Text = "1";
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


        private void butadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text) ||
       string.IsNullOrWhiteSpace(txtname.Text) ||
       string.IsNullOrWhiteSpace(txtsuplier.Text) ||
       string.IsNullOrWhiteSpace(txtcatogary.Text) ||
       string.IsNullOrWhiteSpace(txtcost.Text) ||
       string.IsNullOrWhiteSpace(txtsellingprice.Text) ||
       string.IsNullOrWhiteSpace(txtfraction.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = @"INSERT INTO [item] 
                             (item_code, item_name, categary, suplier, cost, min_price, selling_price, wholesale_price, fraction, whole_qty) 
                             VALUES 
                             (@code, @item_name, @category, @suplier, @cost, @min_price, @selling_price, @wholesale_price, @fraction, @whole_qty)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        if (double.TryParse(txtcode.Text.Trim(), out double itemCode))
                        {
                            cmd.Parameters.AddWithValue("@code", itemCode);
                        }
                        else
                        {
                            MessageBox.Show("Invalid item code. Please enter a valid number.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@item_name", txtname.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", txtcatogary.Text.Trim());
                        cmd.Parameters.AddWithValue("@suplier", txtsuplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@min_price",txtminimumprice.Text.Trim());

                        if (double.TryParse(txtcost.Text.Trim(), out double cost))
                        {
                            cmd.Parameters.AddWithValue("@cost", cost);
                        }
                        else
                        {
                            MessageBox.Show("Invalid cost. Please enter a valid number.");
                            return;
                        }

                      

                        if (double.TryParse(txtsellingprice.Text.Trim(), out double sellingPrice))
                        {
                            cmd.Parameters.AddWithValue("@selling_price", sellingPrice);
                        }
                        else
                        {
                            MessageBox.Show("Invalid selling price. Please enter a valid number.");
                            return;
                        }

                        // Add optional fields with validation
                        if (string.IsNullOrWhiteSpace(txtwholesaleprice.Text))
                        {
                            cmd.Parameters.AddWithValue("@wholesale_price", DBNull.Value);
                        }
                        else if (double.TryParse(txtwholesaleprice.Text.Trim(), out double wholesalePrice))
                        {
                            cmd.Parameters.AddWithValue("@wholesale_price", wholesalePrice);
                        }
                        else
                        {
                            MessageBox.Show("Invalid wholesale price. Please enter a valid number.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtquntity.Text))
                        {
                            cmd.Parameters.AddWithValue("@whole_qty", DBNull.Value);
                        }
                        else if (int.TryParse(txtquntity.Text.Trim(), out int quantity))
                        {
                            cmd.Parameters.AddWithValue("@whole_qty", quantity);
                        }
                        else
                        {
                            MessageBox.Show("Invalid quantity. Please enter a valid number.");
                            return;
                        }

                        if (double.TryParse(txtfraction.Text.Trim(), out double fraction))
                        {
                            cmd.Parameters.AddWithValue("@fraction", fraction);
                        }
                        else
                        {
                            MessageBox.Show("Invalid fraction. Please enter a valid number.");
                            return;
                        }

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully added to the database.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void butdelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text))
            {
                MessageBox.Show("Please enter the item code to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = "DELETE FROM [item] WHERE item_code = @item_code";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@item_code", txtcode.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void butupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text))
            {
                MessageBox.Show("Please enter the item code to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    string query = @"UPDATE [item] 
                         SET item_name = @item_name, 
                             categary = @categary, 
                             suplier = @suplier, 
                             cost = @cost, 
                             min_price = @min_price, 
                             selling_price = @selling_price, 
                             wholesale_price = @wholesale_price, 
                             fraction = @fraction, 
                             whole_qty = @whole_qty
                         WHERE item_code = @item_code";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@item_code", txtcode.Text.Trim());
                        cmd.Parameters.AddWithValue("@item_name", txtname.Text.Trim());
                        cmd.Parameters.AddWithValue("@categary", txtcatogary.Text.Trim());
                        cmd.Parameters.AddWithValue("@suplier", txtsuplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@cost", double.Parse(txtcost.Text.Trim()));
                        cmd.Parameters.AddWithValue("@min_price", txtminimumprice.Text.Trim());
                        cmd.Parameters.AddWithValue("@selling_price", double.Parse(txtsellingprice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@wholesale_price",
                            string.IsNullOrWhiteSpace(txtwholesaleprice.Text) ? (object)DBNull.Value : double.Parse(txtwholesaleprice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@fraction",
                            string.IsNullOrWhiteSpace(txtfraction.Text) ? (object)DBNull.Value : double.Parse(txtfraction.Text.Trim()));
                        cmd.Parameters.AddWithValue("@whole_qty",
                            string.IsNullOrWhiteSpace(txtquntity.Text) ? (object)DBNull.Value : int.Parse(txtquntity.Text.Trim()));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtsuplier.Focus();


            }
        }

        private void txtsuplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcatogary.Focus();


            }
        }

        private void txtcatogary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcost.Focus();


            }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtfraction.Focus();


            }
        }

        private void txtfraction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtsellingprice.Focus();


            }
        }

        private void txtsellingprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtminimumprice.Focus();


            }
        }

        private void txtminimumprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtwholesaleprice.Focus();


            }
        }

        private void txtwholesaleprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtquntity.Focus();


            }
        }
    }
}
