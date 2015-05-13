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
    public partial class CatalogScreen : Form
    {
        //properties
        Catalog tempCatalog;
        int catalogId;
        int itemId;

        bool editing = false;


        /// <summary>
        /// Default Constructor
        /// </summary>
        public CatalogScreen()
        {
            InitializeComponent();
            tempCatalog = new Catalog();
        }

        /// <summary>
        /// Constructor for editing an existing catalog
        /// </summary>
        /// <param name="catalogId">CatalogId of catalog to be edited</param>
        public CatalogScreen(int catalogId)
        {
            InitializeComponent();

            editing = true;
            tempCatalog = Catalog.getCatalogById(catalogId);
            this.catalogId = catalogId;

            //fill form ui from retreived object
            txtId.Text = Convert.ToString(tempCatalog.id);
            txtQuarter.Text = tempCatalog.quarter;
            txtNotes.Text = tempCatalog.notes;
            cboStatus.Text = tempCatalog.status;
        }

        private void CatalogScreen_Load(object sender, EventArgs e)
        {
            //fill product list box
            if (catalogId > 0)
            {
                cboProducts.DataSource = Catalog.getItemsForCatalog(catalogId);
                cboProducts.DisplayMember = "productName";
                cboProducts.ValueMember = "id";
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //add the catalog as it is so far if its a new Catalog being worked on
            if (editing == false)
                AddPlaceholder();
            
            CatalogItemScreen cis = new CatalogItemScreen(catalogId);
            cis.MdiParent = this.MdiParent;
            cis.Show();
            this.Close();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            if (editing == false)
                AddPlaceholder();

            CatalogItemScreen cis = new CatalogItemScreen(catalogId, itemId);
            cis.MdiParent = this.MdiParent;
            cis.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CatalogItem.deleteCatalogsItem(itemId);
        }

        private void SetCatalog()
        {
            tempCatalog.quarter = txtQuarter.Text;
            tempCatalog.status = cboStatus.Text.ToString();
            tempCatalog.notes = txtNotes.Text;
        }

        public void AddPlaceholder()
        {
            SetCatalog();
            Catalog.insertCatalog(tempCatalog);

            //get added catalog's id
            int count = (Catalog.getAllCatalogs().Count);
            catalogId = Catalog.getAllCatalogs()[count - 1].id;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SetCatalog();
            
            //call correct method based on whether adding or updating
            if(editing == true)
            {
                //update exisitng catalog
                Catalog.updateCatalog(tempCatalog);

            }
            else
            {
                //insert new Catalog
                Catalog.insertCatalog(tempCatalog);
            }
            //return to portal page
            CatalogPortalScreen cps = new CatalogPortalScreen();
            cps.MdiParent = this.MdiParent;
            cps.Show();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CatalogPortalScreen cps = new CatalogPortalScreen();
            cps.MdiParent = this.MdiParent;
            cps.Show(); 
            this.Close();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string s = cboProducts.SelectedValue.ToString();
                itemId = Convert.ToInt32(s);
            }
            catch(Exception)
            { }
        }

        

    }
}
