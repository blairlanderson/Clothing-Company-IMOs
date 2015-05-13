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
    public partial class CompanyContactScreen : Form
    {
        Company owningCompany;
        CompanyContact temp;
        bool editing;

        public CompanyContactScreen(Company comp)
        {
            InitializeComponent();
            grpContactHeader.Text = "Add New " + comp.companyName + " Contact: ";
            temp = new CompanyContact();
            owningCompany = comp;
            editing = false;

        }
        public CompanyContactScreen(int compId)
        {
            InitializeComponent();
            owningCompany = Company.getCompanyById(compId);
            grpContactHeader.Text = "Add New " + owningCompany.companyName + " Contact: ";
            temp = new CompanyContact();
            editing = false;

        }

        public CompanyContactScreen(Company comp, CompanyContact contact, bool edIn)
        {
            InitializeComponent();
            grpContactHeader.Text = "Add New " + comp.companyName + " Contact: ";
            temp = new CompanyContact();
            owningCompany = comp;
            temp = contact;
            editing = edIn;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NewCompanyScreen ncs = new NewCompanyScreen();
            ncs.MdiParent = this.MdiParent;
            ncs.Show();
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {         
            //fill CompanyContact Object
            temp.companyId = owningCompany.Id;

            temp.salutation = txtSalutation.Text;
            temp.firstName = txtFirstName.Text;
            temp.lastName = txtLastName.Text;
            
            temp.title = txtTitle.Text;
            temp.branchId = txtBranchId.Text;
            temp.extension = txtExt.Text;
            temp.title = txtTitle.Text;
            temp.signature = txtSignature.Text;

            //add/update object to Global contacts list -> instead of DB for now
            if (editing == true)
            {
                //replace
                CompanyContact.updateCompanyContact(temp);
            }
            else
            {
                //add
                //Globals.contacts.Add(newContact);
                CompanyContact.insertCompanyContact(temp);
            }
            //return to Cx portal
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();

        }

        private void CompanyContactScreen_Load(object sender, EventArgs e)
        {
            txtSalutation.Text = temp.salutation;
            txtFirstName.Text = temp.firstName;
            txtLastName.Text = temp.lastName;

            txtTitle.Text = temp.title;
            txtBranchId.Text = temp.branchId;
            txtExt.Text = temp.extension;
            txtSignature.Text = temp.signature;
        }

    }
}
