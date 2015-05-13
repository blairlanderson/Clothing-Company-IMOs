using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Product_Service;

public partial class ProductCatalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductServiceSoapClient ps = new ProductServiceSoapClient();
        Repeater1.DataSource = ps.getCatalogProducts();
        Repeater1.DataBind();
    }
}