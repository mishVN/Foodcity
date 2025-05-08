using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class backoffice : Form
    {
        public backoffice()
        {
            InitializeComponent();
        }

        private void customizeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            items items = new items();
            items.Show();
        }

        private void backoffice_Load(object sender, EventArgs e)
        {
            
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockadd add = new stockadd();
            add.Show();

        }

        private void changeAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_account create = new create_account();   
            create.Show();
        }

        private void signOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signoffbc signoff = new signoffbc();
            signoff.Show();
            this.Hide();
        }

        private void salingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalsale tot = new totalsale();
            tot.Show();
        }

        private void loginReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_report login = new Login_report();
            login.Show();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcheque show = new showcheque();
            show.Show();
        }

        private void addChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addcheque add = new addcheque();    
            add.Show();
        }

        private void logOffAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoffuser logoff = new logoffuser();
            logoff.Show();
        }

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lawstock law = new lawstock();
            law.Show();
        }

        private void totalChequeValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalcheque totalcheque = new totalcheque();
            totalcheque.Show();
        }

        private void retunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return @return = new Return();
            @return.Show();
        }
    }
}
