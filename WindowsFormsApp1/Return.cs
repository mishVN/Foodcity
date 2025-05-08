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
    public partial class Return : Form
    {
        private string connString = "Server=localhost;Database=supermarket;User Id=sa;Password=3323;";

        public Return()
        {
            InitializeComponent();
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbillno.Text) ||
            string.IsNullOrWhiteSpace(txtitemcode.Text) ||
            string.IsNullOrWhiteSpace(txtqnty.Text) ||
            string.IsNullOrWhiteSpace(txtreson.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                int bill_no = int.Parse(txtbillno.Text);
                int itemcode = int.Parse(txtitemcode.Text);
                int quantityReturned = int.Parse(txtqnty.Text);
                string returnReason = txtreson.Text;

                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    
                    using (SqlCommand cmd = new SqlCommand("dbo.RecordCustomerReturn", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@SaleID", bill_no);
                        cmd.Parameters.AddWithValue("@ProductID", itemcode);
                        cmd.Parameters.AddWithValue("@QuantityReturned", quantityReturned);
                        cmd.Parameters.AddWithValue("@ReturnReason", returnReason);

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Return recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for SaleID, ProductID, and Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
