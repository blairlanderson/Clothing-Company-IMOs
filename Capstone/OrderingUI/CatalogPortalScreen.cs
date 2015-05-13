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
    public partial class CatalogPortalScreen : Form
    {
        int catalogId;

        public CatalogPortalScreen()
        {
            InitializeComponent();
        }

        private void btnNewCatalog_Click(object sender, EventArgs e)
        {
            CatalogScreen cs = new CatalogScreen();
            cs.MdiParent = this.MdiParent;
            cs.Show();
            this.Close();
        }

        private void CatalogPortalScreen_Load(object sender, EventArgs e)
        {
            //set the combo box from DB
            cboUpdateCatalog.DataSource = Catalog.getAllCatalogs();
            cboUpdateCatalog.DisplayMember = "quarter";
            cboUpdateCatalog.ValueMember = "id";
        }

        private void cboUpdateCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string s = cboUpdateCatalog.SelectedValue.ToString();
                catalogId = Convert.ToInt32(s);
            }
            catch(Exception)
            { }
        }

        private void btnDeleteCatalog_Click(object sender, EventArgs e)
        {
            Catalog.deleteCatalog(catalogId);
            MessageBox.Show("Catalog Deleted");

            CatalogPortalScreen cps = new CatalogPortalScreen();
            cps.MdiParent = this.MdiParent;
            cps.Show();
            this.Close();
        }

        private void btnUpdateCatalog_Click(object sender, EventArgs e)
        {
            CatalogScreen cs = new CatalogScreen(catalogId);
            cs.MdiParent = this.MdiParent;
            cs.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
