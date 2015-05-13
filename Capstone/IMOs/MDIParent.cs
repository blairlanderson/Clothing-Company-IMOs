using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using OrderingUI;
using ManufacturingTest2;
using BusinessLogic;
using BusinessLib;

namespace UGFormUI
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCompanyScreen ncs = new NewCompanyScreen();
            ncs.MdiParent = this;
            ncs.Show();
            DisposeAllButThis(ncs);
            
            
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cps = new CustomerPortalScreen();
            cps.MdiParent = this;
            cps.Show();
            DisposeAllButThis(cps);
            
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cps = new CustomerPortalScreen();
            cps.MdiParent = this;
            cps.Show();
            
            DisposeAllButThis(cps);
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

        }

        private void manufacturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.MdiParent = this;
            m.Show();
            
            //this.Size = new Size(m.Width + 5, m.Height + 35);
            m.WindowState = FormWindowState.Maximized;
            DisposeAllButThis(m);
        }

        private void orderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cps = new CustomerPortalScreen();
            cps.MdiParent = this;
            cps.Show();
        }

        private void modifyCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogPortalScreen cps = new CatalogPortalScreen();
            cps.MdiParent = this;
            cps.Show();
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Close();
                }
            }
        }//end disposal class
       

    }//end mdi class
}
