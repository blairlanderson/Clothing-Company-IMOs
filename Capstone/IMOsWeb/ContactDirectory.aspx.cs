using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Contact_Service;

public partial class ContactDirectory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CompContactServiceSoapClient ccs = new CompContactServiceSoapClient();
        Repeater1.DataSource = ccs.getAllContacts();
        Repeater1.DataBind();
    }
}