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
    public partial class CustomerPortalScreen : Form
    {
        int companyId;
        Company editee;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomerPortalScreen()
        {
            InitializeComponent();
        }

        private void CustomerPortalScreen_Load(object sender, EventArgs e)
        {
            this.MdiParent.Size = new Size(this.Width + 5, this.Height + 35);
            
            //REFERENCE: http://stackoverflow.com/questions/600869/how-to-bind-a-list-to-a-combobox-winforms
            //fill the combo box with the names of the:
            //companies from the database
            cboUpdateCustomer.DataSource = Company.getAllCompanies();//Globals.companies;
            cboUpdateCustomer.DisplayMember = "companyName";
            cboUpdateCustomer.ValueMember = "Id";
            
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            //Send to New CX Page

            NewCompanyScreen ncs = new NewCompanyScreen();
            ncs.MdiParent = this.MdiParent;
            ncs.Show();
            this.Close();
            
        }

        private void cboUpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //companyId = cboUpdateCustomer.SelectedIndex +1;
            try
            {
                string convertS = cboUpdateCustomer.SelectedValue.ToString();
                companyId = Convert.ToInt32(convertS);
            }
            catch (Exception)
            { }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (companyId < 1)
                companyId = 1005; //set redirect with 
            
            EditCompanyScreen eds = new EditCompanyScreen(companyId);
            eds.MdiParent = this.MdiParent;
            eds.Show();
            this.Close();
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            
            //Globals.companies.RemoveAt(companyId);
            Company.deleteCompany(companyId);
            MessageBox.Show("Company Deleted");

            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            //editee = Globals.companies[companyId];
            //ContactPortalScreen cps = new ContactPortalScreen(editee);
            ContactPortalScreen cps = new ContactPortalScreen(companyId);
            cps.MdiParent = this.MdiParent;
            cps.Show();
            this.Close();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            //editee = Globals.companies[companyId];
            
            //OrderPortalScreen ops = new OrderPortalScreen(editee);
            OrderPortalScreen ops = new OrderPortalScreen(companyId);
            ops.MdiParent = this.MdiParent;
            ops.Show();
            this.Close();
        }

        //return to splash screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.MdiParent = this.MdiParent;
            splash.Show();
            this.Close();
        }

    }
}
