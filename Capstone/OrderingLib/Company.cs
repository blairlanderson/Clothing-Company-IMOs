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
    public class Company : Contact
    {
        //company specific properties
        public int companyId { get; set; }
        public string companyName { get; set; }

        public string description { get; set; }
        public List<Order> orders { get; set; }

        //data access methods
        public static List<Company> getAllCompanies()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetAllCompanies";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Company> companies = new List<Company>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Company tempComp = new Company();
                tempComp.Id = System.Convert.ToInt32(dr["id"]);
                tempComp.companyName = dr["companyName"].ToString();
                tempComp.city = dr["city"].ToString();
                tempComp.province = dr["province"].ToString();
                tempComp.postalCode = dr["postalCode"].ToString();
                tempComp.phoneNum = dr["phoneNum"].ToString();
                tempComp.description = dr["descript"].ToString();
                tempComp.dateEntered = System.Convert.ToDateTime(dr["dateEntered"]);
                
                companies.Add(tempComp);
            }
            return companies;
        }//end getallCompanys

        public static int insertCompany(Company aComp)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_insertCompany";
            SqlParameter[] sps = new SqlParameter[12];
            sps[0] = new SqlParameter("@companyName", aComp.companyName);
            sps[1] = new SqlParameter("@addressA", aComp.addressLineA);
            sps[2] = new SqlParameter("@addressB", aComp.addressLineB);
            sps[3] = new SqlParameter("@city", aComp.city);
            sps[4] = new SqlParameter("@province", aComp.province);
            sps[5] = new SqlParameter("@postalCode", aComp.postalCode);
            sps[6] = new SqlParameter("@phoneNum", aComp.phoneNum);
            sps[7] = new SqlParameter("@altPhoneNum", aComp.altPhoneNum);
            sps[8] = new SqlParameter("@faxNum", aComp.faxNum);
            sps[9] = new SqlParameter("@descript", aComp.description);
            sps[10] = new SqlParameter("@notes", aComp.notes);
            sps[11] = new SqlParameter("@dateEntered", aComp.dateEntered);

            Globals.compIds.Add(aComp.Id);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        //TODO TEST getCompById
        public static Company getCompanyById(int compId)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetCompanyById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", compId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);

            Company aCompany = new Company();
            aCompany.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
            aCompany.companyName = ds.Tables[0].Rows[0]["companyName"].ToString();

            aCompany.addressLineA = ds.Tables[0].Rows[0]["addressA"].ToString();
            aCompany.addressLineB = ds.Tables[0].Rows[0]["addressB"].ToString();
            aCompany.city = ds.Tables[0].Rows[0]["city"].ToString();
            aCompany.province = ds.Tables[0].Rows[0]["province"].ToString();
            aCompany.postalCode = ds.Tables[0].Rows[0]["postalCode"].ToString();

            aCompany.phoneNum = ds.Tables[0].Rows[0]["phoneNum"].ToString();
            aCompany.altPhoneNum = ds.Tables[0].Rows[0]["altPhoneNum"].ToString();
            aCompany.faxNum = ds.Tables[0].Rows[0]["faxNum"].ToString();
            aCompany.description = ds.Tables[0].Rows[0]["descript"].ToString();
            aCompany.companyId = aCompany.Id;
            //TODO Fix? aCompany.dateEntered = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["dateEntered"]);

            return aCompany;
        }

        public static List<CompanyContact> getContactsForCompany(int compId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetContactsForCompany";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@companyId", compId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<CompanyContact> compContacts = new List<CompanyContact>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CompanyContact tempContact = new CompanyContact();
                tempContact.id = System.Convert.ToInt32(dr["id"]);
                tempContact.firstName = dr["firstName"].ToString();
                tempContact.lastName = dr["lastName"].ToString();

                compContacts.Add(tempContact);
            }
            return compContacts;
        }

        public static List<Order> getOrdersForCompany(int compId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetOrdersForCompany";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@companyId", compId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Order temp = new Order();
                temp.id = System.Convert.ToInt32(dr["id"]);
                temp.orderDate = System.Convert.ToDateTime(dr["orderDate"]);

                orders.Add(temp);
            }
            return orders;
        }

        public static int updateCompany(Company aComp)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_UpdateCompany";
            SqlParameter[] sps = new SqlParameter[12];
            sps[0] = new SqlParameter("@companyName", aComp.companyName);
            sps[1] = new SqlParameter("@addressA", aComp.addressLineA);
            sps[2] = new SqlParameter("@addressB", aComp.addressLineB);
            sps[3] = new SqlParameter("@city", aComp.city);
            sps[4] = new SqlParameter("@province", aComp.province);
            sps[5] = new SqlParameter("@postalCode", aComp.postalCode);
            sps[6] = new SqlParameter("@phoneNum", aComp.phoneNum);
            sps[7] = new SqlParameter("@altPhoneNum", aComp.altPhoneNum);
            sps[8] = new SqlParameter("@faxNum", aComp.faxNum);
            sps[9] = new SqlParameter("@descript", aComp.description);
            sps[10] = new SqlParameter("@notes", aComp.notes);
            
            sps[11] = new SqlParameter("@id", aComp.Id);

            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static void deleteCompany(int compId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_DeleteCompany";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", compId);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }
    }

    
}
