using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using BusinessLib;

/// <summary>
/// Summary description for CompContactService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CompContactService : System.Web.Services.WebService {

    public CompContactService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<CompanyContact> getAllContacts() {
        return CompanyContact.getAllCompanyContacts();
    }
    
}
