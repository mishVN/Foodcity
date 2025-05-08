using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class pos : Form
    {
        string connstring = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";
        SqlConnection conn;

        public pos()
        {
            InitializeComponent();
            conn = new SqlConnection(connstring);
        }

        private void label14_Click(object sender, EventArgs e)
        {
           singoffpos off = new singoffpos();
            off.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            singoffpos off = new singoffpos();
            off.Show();
            this.Hide();
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
                        string query = @"SELECT item_name, min_price, whole_qty, selling_price, fraction, wholesale_price 
                                 FROM [item] 
                                 WHERE item_code = @code OR barcode = @code";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@code", txtcode.Text.Trim());

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                   
                                    string itemName = reader["item_name"]?.ToString() ?? string.Empty;
                                    double minimumPrice = 0.0; 
                                    if (reader["min_price"] != DBNull.Value && !string.IsNullOrWhiteSpace(reader["min_price"].ToString()))
                                    {
                                        if (double.TryParse(reader["min_price"].ToString(), out double result))
                                        {
                                            minimumPrice = result;
                                        }
                                        
                                    }

                                    double sellingPrice = reader["selling_price"] != DBNull.Value ? Convert.ToDouble(reader["selling_price"]) : 0.0;
                                    double wholesalePrice = reader["wholesale_price"] != DBNull.Value ? Convert.ToDouble(reader["wholesale_price"]) : 0.0;
                                    double fraction = reader["fraction"] != DBNull.Value ? Convert.ToDouble(reader["fraction"]) : 0.0;
                                    int quantity = reader["whole_qty"] != DBNull.Value ? Convert.ToInt32(reader["whole_qty"]) : 0;

                                   
                                    txtname.Text = itemName;
                                    txtprice.Text = sellingPrice.ToString();
                                    lbldisqnty.Text = quantity.ToString();
                                    lblminprice.Text = minimumPrice.ToString();
                                    lblfraction.Text = fraction.ToString();
                                    lblwholesaleprice.Text = wholesalePrice.ToString();

                                   
                                    txtquantity.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("No item found with the given code.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (e.KeyChar == (char)Keys.Escape)
            {
                txtcustomer.Focus();
            }
        }


        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (!int.TryParse(lbldisqnty.Text, out int qnty))
                {
                   
                    return;
                }

                if (!double.TryParse(txtprice.Text, out double sellingPrice))
                {
                    
                    return;
                }

                if (!double.TryParse(txtquantity.Text, out double quantity) || quantity <= 0)
                {
                    
                    return;
                }

                if (!double.TryParse(lblwholesaleprice.Text, out double wholesalePrice))
                {
                    
                    return;
                }

                
                double minimumPrice = 0.0;
                if (!string.IsNullOrWhiteSpace(lblminprice.Text) && double.TryParse(lblminprice.Text, out double minPrice))
                {
                    minimumPrice = minPrice;
                }

                if (!double.TryParse(lblfraction.Text, out double fraction) || fraction <= 0)
                {
                   
                    return;
                }

                double price, discount, total;

                if (qnty > 0)
                {

                    if (quantity >= qnty)
                    {
                        price = wholesalePrice;
                        discount = sellingPrice - wholesalePrice;
                        total = (price / fraction) * (quantity * fraction);
                        txttotal.Text = total.ToString("F2");
                        txtprice.Text = price.ToString("F2");
                        txtdiscount.Text = discount.ToString("F2");
                    }
                }
                else
                {
                    if (minimumPrice > 1)
                    {
                        
                        discount = sellingPrice - minimumPrice;
                        price = sellingPrice - discount;
                    }
                    else
                    {
                        discount = 0;
                        price = sellingPrice;
                    }

                    total = (price / fraction) * (quantity * fraction);
                    txttotal.Text = total.ToString("F2");
                    txtprice.Text = price.ToString("F2");
                    txtdiscount.Text = discount.ToString("F2");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    
                    string code = txtcode.Text.Trim();
                    string name = txtname.Text.Trim();
                    string priceText = txtprice.Text.Trim();
                    string quantityText = txtquantity.Text.Trim();
                    string discountText = txtdiscount.Text.Trim();
                    string totalText = txttotal.Text.Trim();

                    if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) ||
                        string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText) ||
                        string.IsNullOrEmpty(totalText))
                    {
                        
                        return;
                    }

                  
                    if (!double.TryParse(priceText, out double price))
                    {
                      
                        return;
                    }

                    if (!int.TryParse(quantityText, out int quantity))
                    {
                       
                        return;
                    }

                    if (!double.TryParse(totalText, out double total))
                    {
                      
                        return;
                    }

                    
                    double discount = 0;
                    if (!string.IsNullOrEmpty(discountText))
                    {
                        if (!double.TryParse(discountText, out discount))
                        {
                            discount = discount * quantity;
                            
                            return;
                        }
                    }

                  
                    dataGridView1.Rows.Add(code, name, quantity, discount, price, total);

                    
                    txtcode.Clear();
                    txtname.Clear();
                    txtprice.Clear();
                    txtquantity.Clear();
                    txtdiscount.Clear();
                    txttotal.Clear();

                    
                    txtcode.Focus();

                    try
                    {
                        double totalSum = 0;  
                        double discountSum = 0; 

                       
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                           
                            if (row.IsNewRow) continue;

                            
                            if (row.Cells["dgvtotal"].Value != null &&
                                double.TryParse(row.Cells["dgvtotal"].Value.ToString(), out double totalValue))
                            {
                                totalSum += totalValue;
                            }

                            
                            if (row.Cells["dgvdiscount"].Value != null &&
                                double.TryParse(row.Cells["dgvdiscount"].Value.ToString(), out double discountValue))
                            {
                                discountSum += discountValue;
                            }
                        }

                        
                        lbltotal.Text = totalSum.ToString("F2"); 
                        lbldiscount.Text = discountSum.ToString("F2"); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating totals: {ex.Message}");
                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
               try
                {

                    string code = txtcode.Text.Trim();
                    string name = txtname.Text.Trim();
                    string priceText = txtprice.Text.Trim();
                    string quantityText = txtquantity.Text.Trim();
                    string discountText = txtdiscount.Text.Trim();
                    string totalText = txttotal.Text.Trim();

                    if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name) ||
                        string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText) ||
                        string.IsNullOrEmpty(totalText))
                    {

                        return;
                    }


                    if (!double.TryParse(priceText, out double price))
                    {

                        return;
                    }

                    if (!int.TryParse(quantityText, out int quantity))
                    {

                        return;
                    }

                    if (!double.TryParse(totalText, out double total))
                    {

                        return;
                    }


                    double discount = 0;
                    if (!string.IsNullOrEmpty(discountText))
                    {
                        if (!double.TryParse(discountText, out discount))
                        {
                            discount = discount * quantity;

                            return;
                        }
                    }


                    dataGridView1.Rows.Add(code, name, quantity, discount, price, total);


                    txtcode.Clear();
                    txtname.Clear();
                    txtprice.Clear();
                    txtquantity.Clear();
                    txtdiscount.Clear();
                    txttotal.Clear();


                    txtcode.Focus();

                    try
                    {
                        double totalSum = 0;
                        double discountSum = 0;


                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {

                            if (row.IsNewRow) continue;


                            if (row.Cells["dgvtotal"].Value != null &&
                                double.TryParse(row.Cells["dgvtotal"].Value.ToString(), out double totalValue))
                            {
                                totalSum += totalValue;
                            }


                            if (row.Cells["dgvdiscount"].Value != null &&
                                double.TryParse(row.Cells["dgvdiscount"].Value.ToString(), out double discountValue))
                            {
                                discountSum += discountValue;
                            }
                        }


                        lbltotal.Text = totalSum.ToString("F2");
                        lbldiscount.Text = discountSum.ToString("F2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating totals: {ex.Message}");
                    }






                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtcash.Focus();

        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcash.Text))
            {
                return;
            }
        }

        private void txtcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (!double.TryParse(lbltotal.Text, out double total))
                {

                    return;
                }
                if (!double.TryParse(txtcash.Text, out double cash))
                {

                    return;
                }
                if (cash >= total)
                {
                    double balance = cash - total;
                    lblbalance.Text = balance.ToString();
                    MessageBox.Show("Balance is" + balance, "Cash Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    if (string.IsNullOrWhiteSpace(txtcash.Text))
                    {
                        MessageBox.Show("Please fill in Cash Value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connstring))
                        {
                            conn.Open();

                            string query = @"INSERT INTO [bill_details] (bill_number, total_amount, cusname, bill_date) 
                         VALUES (@bill_number, @total_amount, @cusname, @date)";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@bill_number", lblbillnumber.Text.Trim());
                                cmd.Parameters.AddWithValue("@total_amount", lbltotal.Text.Trim());

                                
                                if (string.IsNullOrWhiteSpace(txtcustomer.Text))
                                {
                                    cmd.Parameters.AddWithValue("@cusname", DBNull.Value);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@cusname", txtcustomer.Text.Trim());
                                }

                                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    dataGridView1.Rows.Clear();
                                    lbltotal.Text = string.Empty;
                                    lbldiscount.Text = string.Empty;
                                    lblbalance.Text = string.Empty;
                                    button3.PerformClick();
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
                else
                {
                   
                    txtcash.PerformLayout();
                }
        }
        

        private void butprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            

            
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font itemFont = new Font("Arial", 10);
            Font totalFont = new Font("Arial", 10, FontStyle.Bold);
            int lineHeight = 20;

            
            int y = 10;

            
            e.Graphics.DrawString("Welcome", headerFont, Brushes.Black, 10, y);
            y += lineHeight;
            e.Graphics.DrawString("ABC FoodCity", itemFont, Brushes.Black, 10, y);
            y += lineHeight * 2;

            
            e.Graphics.DrawString("Item", itemFont, Brushes.Black, 10, y);
            e.Graphics.DrawString("Price", itemFont, Brushes.Black, 150, y);
            e.Graphics.DrawString("Qty", itemFont, Brushes.Black, 250, y);
            e.Graphics.DrawString("Total", itemFont, Brushes.Black, 350, y);
            y += lineHeight;

            
            e.Graphics.DrawLine(Pens.Black, 10, y, 400, y);
            y += lineHeight / 2;

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["dgvname"].Value != null &&
                    row.Cells["dgvunitprice"].Value != null &&
                    row.Cells["dgvquantity"].Value != null &&
                    row.Cells["dgvtotal"].Value != null)
                {
                    string itemName = row.Cells["dgvname"].Value.ToString();
                    string itemPrice = row.Cells["dgvunitprice"].Value.ToString();
                    string itemQuantity = row.Cells["dgvquantity"].Value.ToString();
                    string itemTotal = row.Cells["dgvtotal"].Value.ToString();

                    e.Graphics.DrawString(itemName, itemFont, Brushes.Black, 10, y);
                    e.Graphics.DrawString(itemPrice, itemFont, Brushes.Black, 150, y);
                    e.Graphics.DrawString(itemQuantity, itemFont, Brushes.Black, 250, y);
                    e.Graphics.DrawString(itemTotal, itemFont, Brushes.Black, 350, y);

                    y += lineHeight;
                }
            }

            
            e.Graphics.DrawLine(Pens.Black, 10, y, 400, y);
            y += lineHeight / 2;


            if (!double.TryParse(lbltotal.Text, out double total))
            {

                return;
            }
            if (!double.TryParse(lbldiscount.Text, out double discount))
            {

                return;
            }

            e.Graphics.DrawString("Total:"+total, totalFont, Brushes.Black, 10, y);
            e.Graphics.DrawString("Discount:" + discount, totalFont, Brushes.Black, 250, y);
            y += lineHeight;

            if (!double.TryParse(lblbalance.Text, out double balance))
            {

                return;
            }
            e.Graphics.DrawString("Balance:" + balance, new Font("Areal", 15, FontStyle.Bold), Brushes.Black, 100, y);

            y += lineHeight;
            e.Graphics.DrawString("ThankYou", itemFont, Brushes.Black, 10, y);
            y += lineHeight;
            e.Graphics.DrawString("Come Again", itemFont, Brushes.Black, 10, y);
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pos_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open(); 

                    
                    string queryLogin = "SELECT user_name FROM [tem_login] WHERE system = 'pos'";

                    using (SqlCommand cmd = new SqlCommand(queryLogin, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string username = reader.IsDBNull(reader.GetOrdinal("user_name")) ? string.Empty : reader["user_name"].ToString();
                                lblusername.Text = username;
                            }
                        }
                    }

                    
                    string queryCash = "SELECT cash_value FROM [cash] WHERE user_name = @username";

                    using (SqlCommand cmd = new SqlCommand(queryCash, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@username", lblusername.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string cashvalue = reader.IsDBNull(reader.GetOrdinal("cash_value")) ? string.Empty : reader["cash_value"].ToString();
                                lblavailablebal.Text = cashvalue;
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



        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                    
                    string query = "SELECT TOP 1 bill_number FROM [bill_details] ORDER BY bill_number DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int code = Convert.ToInt32(result);
                            code = code + 1;
                            lblbillnumber.Text = code.ToString();

                            txtcode.Focus();
                        }
                        else
                        {
                            
                            lblbillnumber.Text = "100000";
                            txtcode.Focus();
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

        private void txtcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtcash.Focus();
            }
        }

        private void cashout_Click(object sender, EventArgs e)
        {
            decimal cashInput;

            if (decimal.TryParse(txtvalue.Text, out cashInput))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connstring))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("UpdateCashOutValue", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@cash_input", cashInput);

                            SqlParameter outputParam = new SqlParameter
                            {
                                ParameterName = "@result_message",
                                SqlDbType = SqlDbType.NVarChar,
                                Size = 255,
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputParam);

                            cmd.ExecuteNonQuery();

                            string resultMessage = outputParam.Value.ToString();
                            MessageBox.Show(resultMessage, "Update Cash Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

           
        }

        private void cashin_Click(object sender, EventArgs e)
        {
            decimal cashInput;

            if (decimal.TryParse(txtvalue.Text, out cashInput))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connstring))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("UpdateCashInValue", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@cash_input", cashInput);

                            SqlParameter outputParam = new SqlParameter
                            {
                                ParameterName = "@result_message",
                                SqlDbType = SqlDbType.NVarChar,
                                Size = 255,
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputParam);

                            cmd.ExecuteNonQuery();

                            string resultMessage = outputParam.Value.ToString();
                            MessageBox.Show(resultMessage, "Update Cash Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void label16_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    conn.Open();

                   
                    string queryLogin = "SELECT user_name FROM [tem_login] WHERE system ='pos'";

                    using (SqlCommand cmd = new SqlCommand(queryLogin, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string username = reader.IsDBNull(reader.GetOrdinal("user_name")) ? string.Empty : reader["user_name"].ToString();
                                lblusername.Text = username;
                            }
                        }
                    }

                  
                    string queryCash = "SELECT cash_value FROM [cash] WHERE user_name = @username";

                    using (SqlCommand cmd = new SqlCommand(queryCash, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@username", lblusername.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string cashvalue = reader.IsDBNull(reader.GetOrdinal("cash_value")) ? string.Empty : reader["cash_value"].ToString();
                                lblavailablebal.Text = cashvalue;
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
    
    
    
    
    
}
