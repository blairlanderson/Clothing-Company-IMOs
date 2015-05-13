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
using BusinessLogic;

namespace OrderingUI
{
    public partial class CatalogItemScreen : Form
    {
        Catalog owningCatalog;
        CatalogItem tempItem;
        bool editing = false;

        int catalogId;
        int itemId;

        public CatalogItemScreen(int catalogId)
        {
            InitializeComponent();
            owningCatalog = Catalog.getCatalogById(catalogId);

            tempItem = new CatalogItem();
            editing = false;

            this.catalogId = catalogId;
        }

        public CatalogItemScreen(int catalogId, int itemId)
        {
            InitializeComponent();
            owningCatalog = Catalog.getCatalogById(catalogId);
            this.catalogId = catalogId;

            tempItem = CatalogItem.getCatalogItemById(itemId);
            this.itemId = itemId;
            editing = true;

            //fill form ui from retreived object
            txtCatalogId.Text = catalogId.ToString();

        }

        private void CatalogItemScreen_Load(object sender, EventArgs e)
        {
            cboProduct.DataSource = ProductMapper.getAllProducts();
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductlID";
        }
        
        
        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string s = cboProduct.SelectedValue.ToString();
                itemId = Convert.ToInt32(s);
            }
            catch (Exception)
            { }
        }
        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            tempItem.catalogId = this.catalogId;
            tempItem.productId = this.itemId;
            BusinessLogic.Product p = new BusinessLogic.Product(itemId);
            tempItem.productName = ProductMapper.getProductById(p).Name;

            if(editing == true)
            {

            }
            else if (editing == false)
            {
                CatalogItem.insertCatalogItem(tempItem);
            }
            CatalogScreen cs = new CatalogScreen(this.catalogId);
            cs.MdiParent = this.MdiParent;
            cs.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CatalogScreen cs = new CatalogScreen(catalogId);
            cs.MdiParent = this.MdiParent;
            cs.Show();
            this.Close();
        }

        
    }
}
