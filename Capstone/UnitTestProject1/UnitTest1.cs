using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BusinessLib;
using BusinessLogic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetItemsProdName()
        {
            Catalog c = new Catalog();
            c = Catalog.getCatalogById(1);
            
            List<CatalogItem> l = new List<CatalogItem>();
            l = Catalog.getItemsForCatalog(1);
            Console.WriteLine(l[0].productName);
        }

        [TestMethod]
        public void testCompCont()
        {
            CompanyContact.getAllCompanyContacts();
        }
    }
}
