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
    public class CatalogItem
    {
        //properties
        public int id { get; set; }

        public int productId { get; set; }
        public int catalogId { get; set; }
        public string notes { get; set; }
        public string productName { get; set; }

        //db mappers

        public static List<CatalogItem> getAllCatalogItems()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetAllCatalogItems";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<CatalogItem> items = new List<CatalogItem>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CatalogItem temp = new CatalogItem();
                temp.id = System.Convert.ToInt32(dr["id"]);
                temp.productId = System.Convert.ToInt32(dr["productId"]);
                temp.catalogId = System.Convert.ToInt32(dr["catalogId"]);
                temp.notes = dr["notes"].ToString();

                items.Add(temp);
            }
            return items;
        }//end getallcatalogs

        public static int insertCatalogItem(CatalogItem item)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_insertCatalogItem";
            SqlParameter[] sps = new SqlParameter[3];
            sps[0] = new SqlParameter("@productId", item.productId);
            sps[1] = new SqlParameter("@catalodIg", item.catalogId);
            sps[2] = new SqlParameter("@notes", item.notes);

            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static CatalogItem getCatalogItemById(int itemId)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetCatalogItemById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", itemId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);

            CatalogItem item = new CatalogItem();
            item.id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            item.productId = Convert.ToInt32(ds.Tables[0].Rows[0]["productId"]);
            item.catalogId = Convert.ToInt32(ds.Tables[0].Rows[0]["catalogId"]);
            item.notes = ds.Tables[0].Rows[0]["notes"].ToString();

            return item;
        }

        public static void deleteCatalogsItem(int itemId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_DeleteCatalogItem";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", itemId);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

    }//end Catalog class
}
