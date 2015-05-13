using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLib;

namespace OrderingUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void btnOrderPortal_Click(object sender, EventArgs e)
        {
            OrderPortalScreen op = new OrderPortalScreen();
            op.MdiParent = this.MdiParent;
            op.Show();
            this.Close();

        }
    }
}
