using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using BusinessLogic;
using BusinessLib;

/// <summary>
/// Summary description for ProductService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ProductService : System.Web.Services.WebService {

    public ProductService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<Product> getAllProducts() 
    {
        return ProductMapper.getAllProducts();
    }
    
    [WebMethod]
    public List<BusinessLogic.Product> getCatalogProducts()
    {
        List<CatalogItem> items = Catalog.getItemsForCatalog(1);
        List<BusinessLogic.Product> products = new List<BusinessLogic.Product>();

        foreach (CatalogItem item in items)
        {
            int id = item.productId;
            BusinessLogic.Product p = new BusinessLogic.Product(id);
            ProductMapper.getProductById(p);

            products.Add(p);
        }
        
        return products;
    }
}
