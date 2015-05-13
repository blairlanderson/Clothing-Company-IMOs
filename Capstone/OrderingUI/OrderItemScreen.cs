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
    public partial class OrderItemScreen : Form
    {
        Order owningOrder;
        OrderItem newItem;
        Company owningComp;
        int productId;
        string pName;
        int quant;
        int orderId;
        bool editingOrder;
        bool editingItem;
        
        public OrderItemScreen()
        {
            InitializeComponent();
            newItem = new OrderItem();
            editingOrder = false;
        }

        public OrderItemScreen(Order order, Company comp, bool edOrdIn)
        {
            InitializeComponent();
            owningOrder = order;
            orderId = owningOrder.id;
            newItem = new OrderItem();
            owningComp = comp;
            editingOrder = edOrdIn;

        }
        
        /// <summary>
        /// Constructor to be called when editing an existing OrderItem
        /// </summary>
        /// <param name="order"></param>
        /// <param name="comp"></param>
        /// <param name="item"></param>
        /// <param name="edOrdIn"></param>
        /// /// <param name="edIn"></param>
        public OrderItemScreen(Order order, Company comp, OrderItem item, bool edOrdIn, bool edIn)
        {
            InitializeComponent();
            owningOrder = order;
            orderId = owningOrder.id;
            owningComp = comp;
            editingOrder = edOrdIn;
            editingItem = edIn;
            newItem = item;
        }

        private void OrderItemScreen_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = Convert.ToString(owningOrder.id);

            cboProduct.SelectedText = newItem.productName;
            cboQuantity.SelectedText = newItem.quantity.ToString();

            //set Products from global list
            cboProduct.DataSource = ProductMapper.getAllProducts();
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductlId";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderScreen os = new OrderScreen(owningComp, owningOrder, editingOrder);
            os.MdiParent = this.MdiParent;
            os.Show();
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            newItem.orderId = owningOrder.id;
            newItem.productId = productId;
            newItem.productName = pName;//cboProduct.SelectedText;
            newItem.quantity = quant;
            
            if(editingItem == true)
            {
                Globals.orderItems[newItem.id - 1] = newItem;
            }
            else
            {
                Globals.orderItems.Add(newItem);
            }

            OrderScreen os = new OrderScreen(owningComp, owningOrder, editingOrder);
            os.MdiParent = this.MdiParent;
            os.Show();
            this.Close();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string convertS = cboProduct.SelectedValue.ToString();
                productId = Convert.ToInt32(convertS);
                pName = cboProduct.SelectedText;
            }
            catch (Exception)
            { }
        }

        private void cboQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            quant = cboQuantity.SelectedIndex;
        }

        
    }
}
