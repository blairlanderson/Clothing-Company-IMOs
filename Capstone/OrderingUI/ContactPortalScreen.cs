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
    public partial class ContactPortalScreen : Form
    {
        Company owningCompany;
        CompanyContact contact;
        int contactId;
        int companyId;
        
        public ContactPortalScreen(Company comp)
        {
            InitializeComponent();
            owningCompany = comp;
        }
        
        public ContactPortalScreen(int compId)
        {
            InitializeComponent();
            this.companyId = compId;
            owningCompany = Company.getCompanyById(compId);
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            //CompanyContactScreen cc = new CompanyContactScreen(owningCompany);
            CompanyContactScreen cc = new CompanyContactScreen(companyId);
            cc.MdiParent = this.MdiParent;
            cc.Show();
            this.Close();
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            CompanyContactScreen cc = new CompanyContactScreen(owningCompany, contact, true);
            cc.MdiParent = this.MdiParent;
            cc.Show();
            this.Close();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            //Globals.contacts.RemoveAt(contactId);
            CompanyContact.deleteCompanyContact(contactId);
            MessageBox.Show("Contact Deleted");

            ContactPortalScreen cp = new ContactPortalScreen(owningCompany);
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }

        private void ContactPortalScreen_Load(object sender, EventArgs e)
        {
            
            //companyId = owningCompany.companyId;

            //List<CompanyContact> compContacts;
            //compContacts = Globals.contacts.FindAll(FindContacts);
            
            //fill combo list with global contacts list
            cboUpdateContact.DataSource = CompanyContact.getAllCompanyContacts();
            cboUpdateContact.DisplayMember = "firstName";
            cboUpdateContact.ValueMember = "id";
        }

        private void cboUpdateContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string s = cboUpdateContact.SelectedValue.ToString();
                contactId = Convert.ToInt32(s);
                contact = CompanyContact.getContactById(contactId);
            }
            catch(Exception)
            { }
            
            
        }

        private bool FindContacts(CompanyContact contact)
        {
            if(contact.companyId == this.companyId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerPortalScreen cp = new CustomerPortalScreen();
            cp.MdiParent = this.MdiParent;
            cp.Show();
            this.Close();
        }
    }
}
