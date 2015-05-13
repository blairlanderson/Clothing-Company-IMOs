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
    public partial class OrderPortalScreen : Form
    {
        Company owningCompany;
        int companyId;
        Order selectedOrder;
        int orderId;

        public OrderPortalScreen()
        {
            InitializeComponent();
        }

        public OrderPortalScreen(Company comp)
        {
            InitializeComponent(); 
            owningCompany = comp;
        }

        public OrderPortalScreen(int compIn)
        {
            InitializeComponent();
            companyId = compIn;
            owningCompany = Company.getCompanyById(compIn);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.MdiParent = this.MdiParent;
            splash.Show();
            this.Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrderScreen os = new OrderScreen(owningCompany);
            os.MdiParent = this.MdiParent;
            os.Show();
            this.Close();

        }

        private void OrderPortalScreen_Load(object sender, EventArgs e)
        {
            //fill combo box
            cboUpdateOrder.DataSource = Company.getOrdersForCompany(companyId);
            cboUpdateOrder.DisplayMember = "orderDate";
            cboUpdateOrder.ValueMember = "id";
        }

        private bool FindOrders(Order order)
        {
            if(order.companyId == companyId)
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            OrderScreen os = new OrderScreen(owningCompany, selectedOrder, true);
            os.MdiParent = this.MdiParent;
            os.Show();
            this.Close();
        }

        private void cboUpdateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            //orderId = cboUpdateOrder.SelectedIndex;
            //selectedOrder = Globals.orders[orderId];
            try
            {
                string s = cboUpdateOrder.SelectedValue.ToString();
                orderId = Convert.ToInt32(s);
                selectedOrder = Order.getOrderById(orderId);
            }
            catch (Exception)
            { }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            //Globals.orders.RemoveAt(orderId);
            Order.deleteOrder(orderId);
            MessageBox.Show("Order Deleted");

            OrderPortalScreen ops = new OrderPortalScreen(companyId);
            ops.MdiParent = this.MdiParent;
            ops.Show();
            this.Close();
        }
    }
}
