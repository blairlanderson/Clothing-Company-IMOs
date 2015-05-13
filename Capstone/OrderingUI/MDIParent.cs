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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
            SplashScreen splash = new SplashScreen();
            splash.MdiParent = this;
            splash.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            ProductX p1 = new ProductX(1, "Shirt", "a simple shirt", "4.99",
                "shirt.jpg", "medium", "black", "status", "notes");

            ProductX p2 = new ProductX(2, "Pants", "a simple pair of pants", "8.99",
                "pants.jpg", "30x30", "blue", "status", "notes");

            ProductX p3 = new ProductX(3, "Hat", "a simple hat", "5.99",
                "hat.jpg", "8 1/4", "red", "status", "notes");

            Globals.products.Add(p1);
            Globals.products.Add(p2);
            Globals.products.Add(p3);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this;
            cp.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
