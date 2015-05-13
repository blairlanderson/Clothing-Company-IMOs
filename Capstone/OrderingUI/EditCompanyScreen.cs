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
    public partial class EditCompanyScreen : Form
    {
        Company temp;
        int companyId;
        
        public EditCompanyScreen(Company compIn)
        {
            InitializeComponent();
            temp = compIn;
        }

        public EditCompanyScreen(int idIn)
        {
            InitializeComponent();
            temp = Company.getCompanyById(idIn);
            this.companyId = idIn;
        }

        private void EditCompanyScreen_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = temp.companyName;
            txtPhoneNum.Text = temp.phoneNum;
            txtAltPhoneNum.Text = temp.altPhoneNum;
            txtFaxNum.Text = temp.faxNum;

            txtAddressA.Text = temp.addressLineA;
            txtAddressB.Text = temp.addressLineB;
            txtCity.Text = temp.city;

            //province done by changing combo box
            cboProvince.Text = temp.province;
            txtPostalCode.Text = temp.postalCode;

            txtDescription.Text = temp.description;
            txtNotes.Text = temp.notes;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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

            Company.updateCompany(temp);
            MessageBox.Show("Updated Record");

            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void btnManageContacts_Click(object sender, EventArgs e)
        {
            ContactPortalScreen cps = new ContactPortalScreen(companyId);
            cps.MdiParent = this.MdiParent;
            cps.Show();
            this.Close();
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.province = (string)cboProvince.SelectedItem;
        }

        private void grpCompanyGeneral_Enter(object sender, EventArgs e)
        {

        }
    }
}
