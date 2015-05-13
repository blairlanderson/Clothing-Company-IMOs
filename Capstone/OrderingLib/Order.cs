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

namespace BusinessLib
{
    public class Order
    {
        public int id { get; set; }
        public int companyId { get; set; }
        
        public DateTime orderDate { get; set; }
        public string status { get; set; }
        public string notes { get; set; }

        public List<OrderItem> items { get; set; }
        
        public Order()
        {
            items = new List<OrderItem>();
            this.id = Globals.orders.Count + 1;
        }
        
        public static List<Order> getAllOrders()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetAllOrders";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Order temp = new Order();
                temp.id = System.Convert.ToInt32(dr["id"]);
                temp.companyId = System.Convert.ToInt32(dr["customerId"]);
                temp.orderDate = Convert.ToDateTime(dr["orderDate"]);
                
                orders.Add(temp);
            }
            return orders;
        }//end getallorders
        
        public static int insertOrder(Order ord)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_insertOrder";
            SqlParameter[] sps = new SqlParameter[4];
            sps[0] = new SqlParameter("@companyId", ord.companyId);
            sps[1] = new SqlParameter("@orderDate", ord.orderDate);
            sps[2] = new SqlParameter("@status", ord.status);
            sps[3] = new SqlParameter("@notes", ord.notes);
            
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        
        }//end insertOrder

        public static int updateOrder(Order ord)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_updateOrder";
            SqlParameter[] sps = new SqlParameter[5];
            sps[0] = new SqlParameter("@companyId", ord.companyId);
            sps[1] = new SqlParameter("@orderDate", ord.orderDate);
            sps[2] = new SqlParameter("@status", ord.status);
            sps[3] = new SqlParameter("@notes", ord.notes);

            sps[4] = new SqlParameter("@id", ord.id);

            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);

        }//end insertOrder

        public static Order getOrderById(int orderId)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetOrderById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", orderId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);

            Order ord = new Order();
            ord.id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            ord.companyId = Convert.ToInt32(ds.Tables[0].Rows[0]["companyId"]);
            ord.orderDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["orderDate"]);
            ord.status = ds.Tables[0].Rows[0]["status"].ToString();
            ord.notes = ds.Tables[0].Rows[0]["notes"].ToString();
            
            return ord;
        }//end getById

        public static void deleteOrder(int orderId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_DeleteOrder";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", orderId);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }//end deleteOrder
    }   
}
