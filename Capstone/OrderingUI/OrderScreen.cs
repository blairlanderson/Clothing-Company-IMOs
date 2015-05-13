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
    public partial class OrderScreen : Form
    {
        Company owningCompany;
        int companyId;
        Order newOrder;
        
        OrderItem selectedItem;
        int itemId;
        bool editing;

        public OrderScreen()
        {
            InitializeComponent();
            newOrder = new Order();
        }

        public OrderScreen(Company comp)
        {
            InitializeComponent();
            owningCompany = comp;
            newOrder = new Order();
            editing = false;
        }

        public OrderScreen(Company comp, Order order, bool edIn)
        {
            InitializeComponent();
            owningCompany = comp;
            newOrder = order;
            editing = edIn;
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //Fill the combo box with global company list
            cboCustomer.DataSource = Company.getAllCompanies();
            cboCustomer.DisplayMember = "companyName";
            cboCustomer.ValueMember = "Id";

            //set default customer value to current company
            cboCustomer.SelectedValue = owningCompany.companyId;

            //set current orderId + display in 
            txtOrderId.Text = Convert.ToString(newOrder.id); 
            
            //fill cart
            List<OrderItem> temp;
            temp = Globals.orderItems.FindAll(FindItems);
            
            //set cart's combo box properties
            cboCart.DataSource = temp;
            cboCart.DisplayMember = "productName";
            cboCart.ValueMember = "id";

            //read in values if editing/returning
            cboStatus.SelectedText = newOrder.status;
            txtNotes.Text = newOrder.notes;
            
        }

        private bool FindItems(OrderItem item)
        {
            if(item.orderId == newOrder.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderPortalScreen ops = new OrderPortalScreen(owningCompany);

            ops.MdiParent = this.MdiParent;
            ops.Show();
            this.Close();

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SetOrder();

            //add/replace in global orders list
            if (editing == true)
            {
                Order.updateOrder(newOrder);
            }
            else
            {
                //Globals.orders.Add(newOrder);
                Order.insertOrder(newOrder);
            }
            OrderPortalScreen ops = new OrderPortalScreen(owningCompany.Id);
            ops.MdiParent = this.MdiParent;
            ops.Show();
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SetOrder();
            OrderItemScreen ois = new OrderItemScreen(newOrder, owningCompany, editing);
            ois.MdiParent = this.MdiParent;
            ois.Show();
            this.Close();
        }


        private void SetOrder()
        {
            //newOrder = new Order();

            newOrder.companyId = owningCompany.companyId;

            newOrder.orderDate = DateTime.Now;
            newOrder.status = cboStatus.Text.ToString();
            newOrder.notes = txtNotes.Text;

        }

        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            OrderItemScreen ois = new OrderItemScreen(newOrder, owningCompany, selectedItem, editing, true);
            ois.MdiParent = this.MdiParent;
            ois.Show();
            this.Close();
        }

        private void cboCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemId = cboCart.SelectedIndex;
            selectedItem = Globals.orderItems[itemId];
        }

    }
}
