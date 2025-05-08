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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void butpos_Click(object sender, EventArgs e)
        {
            Loginpos loginpos = new Loginpos(); 
            loginpos.Show();
            this.Hide();
        }

        private void butbackoffice_Click(object sender, EventArgs e)
        {
          loginbackoffice loginbackoffice = new loginbackoffice();
            loginbackoffice.Show();
            this.Hide();    

        }
    }
}
