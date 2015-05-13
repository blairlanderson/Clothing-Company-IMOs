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
    public partial class NewCompanyScreen : Form
    {
        Company temp = new Company();
        
        public NewCompanyScreen()
        {
            InitializeComponent();
            
        }

        private void NewCompanyScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            //fill company object
            //Globals.activeCompany.companyId = Globals.companies.Count + 1;
            
            temp.companyName = txtCompanyName.Text;
            temp.phoneNum = txtPhoneNum.Text;
            temp.altPhoneNum = txtAltPhoneNum.Text;
            temp.faxNum = txtFaxNum.Text;

            temp.addressLineA = txtAddressA.Text;
            temp.addressLineB = txtAddressB.Text;
            temp.city = txtCity.Text;
            //province done by changing combo box
            temp.postalCode = txtPostalCode.Text;

            temp.description = txtDescription.Text;
            temp.notes = txtNotes.Text;

            temp.dateEntered = DateTime.Now;
            //add to the global list of companies -> instead of DB for now
            //Globals.companies.Add(temp);

            Company.insertCompany(temp);
            
            //move to next screen
            //CompanyContactScreen cc = new CompanyContactScreen(Globals.activeCompany); // TODO: remove constructor parameters
            CustomerPortalScreen cps = new CustomerPortalScreen();
            cps.MdiParent = this.MdiParent;
            cps.Show();
            //this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.province = (string)cboProvince.SelectedItem;
        }
    }
}
