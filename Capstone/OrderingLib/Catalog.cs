using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; //database objects
using System.Collections;//Array List
using System.Data;

//using DataAccessLib;
using IMOsData;
using BusinessLogic;

namespace BusinessLib
{
    public class Catalog
    {
        //properties
        public int id { get; set; }

        public string quarter { get; set; }
        public string status { get; set; }
        public string notes { get; set; }

        //db mappers

        public static List<Catalog> getAllCatalogs()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetAllCatalogs";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Catalog> catalogs = new List<Catalog>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Catalog temp = new Catalog();
                temp.id = System.Convert.ToInt32(dr["id"]);
                temp.quarter = dr["quarter"].ToString();

                catalogs.Add(temp);
            }
            return catalogs;
        }//end getallcatalogs

        public static int insertCatalog(Catalog aCatalog)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_insertCatalog";
            SqlParameter[] sps = new SqlParameter[3];
            sps[0] = new SqlParameter("@quarter", aCatalog.quarter);
            sps[1] = new SqlParameter("@status", aCatalog.status);
            sps[2] = new SqlParameter("@notes", aCatalog.notes);
            
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static Catalog getCatalogById(int catalogId)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetCatalogById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", catalogId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);

            Catalog aCatalog = new Catalog();
            aCatalog.id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            aCatalog.quarter = ds.Tables[0].Rows[0]["quarter"].ToString();
            aCatalog.status = ds.Tables[0].Rows[0]["status"].ToString();
            aCatalog.notes = ds.Tables[0].Rows[0]["notes"].ToString();

            return aCatalog;
        }

        /* TODO
        public static List<Product> getProductsForCatalog(int catalogId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetProductsForCatalog";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@catalogId", catalogId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Product> items = new List<Product>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Product temp = new Product();
                
                items.Add(temp);
            }
            return items;
        }
         */
        
        public static List<CatalogItem> getItemsForCatalog(int catalogId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetItemsForCatalog";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@catalogId", catalogId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<CatalogItem> items = new List<CatalogItem>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CatalogItem temp = new CatalogItem();
                temp.id = System.Convert.ToInt32(dr["id"]);

                temp.productId = System.Convert.ToInt32(dr["productId"]);
                temp.catalogId = System.Convert.ToInt32(dr["catalogId"]);
                temp.productName = dr["productName"].ToString();
                temp.notes = dr["notes"].ToString();

                items.Add(temp);
            }
            return items;
        }

        public static int updateCatalog(Catalog temp)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_UpdateCatalog";
            SqlParameter[] sps = new SqlParameter[4];
            sps[0] = new SqlParameter("@quarter", temp.quarter);
            sps[1] = new SqlParameter("@status", temp.status);
            sps[2] = new SqlParameter("@notes", temp.notes);
            sps[3] = new SqlParameter("@id", temp.id);

            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static void deleteCatalog(int catalogId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_DeleteCatalog";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", catalogId);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

    }//end Catalog class
}
