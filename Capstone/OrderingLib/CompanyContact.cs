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
    public class CompanyContact
    {
        public int id { get; set; }
        public int companyId { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }

        public string extension { get; set; }
        public string branchId { get; set; }
        public string signature { get; set; }
        public string salutation { get; set; }

        public CompanyContact()
        {
            id = Globals.contacts.Count + 1;
        }


        //data access methods
        public static List<CompanyContact> getAllCompanyContacts()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetAllCompanyContacts";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<CompanyContact> compContacts = new List<CompanyContact>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                CompanyContact tempCon = new CompanyContact();
                tempCon.id = System.Convert.ToInt32(dr["id"]);
                tempCon.companyId = System.Convert.ToInt32(dr["companyId"]);
                tempCon.firstName = dr["firstName"].ToString();
                tempCon.lastName = dr["lastName"].ToString();
                tempCon.title = dr["title"].ToString();
                tempCon.extension = dr["extension"].ToString();
                tempCon.branchId = dr["branch"].ToString();
                tempCon.signature = dr["signature"].ToString();
                tempCon.salutation = dr["salutation"].ToString();

                
                compContacts.Add(tempCon);
            }
            return compContacts;
        }//end getallccompcontacts
       
        public static int insertCompanyContact(CompanyContact aCon)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_insertCompanyContact";
            SqlParameter[] sps = new SqlParameter[8];
            sps[0] = new SqlParameter("@companyId", aCon.companyId);
            sps[1] = new SqlParameter("@firstName", aCon.firstName);
            sps[2] = new SqlParameter("@lastName", aCon.lastName);
            sps[3] = new SqlParameter("@title", aCon.title);
            sps[4] = new SqlParameter("@extension", aCon.extension);
            sps[5] = new SqlParameter("@branch", aCon.branchId);
            sps[6] = new SqlParameter("@signature", aCon.signature);
            sps[7] = new SqlParameter("@salutation", aCon.salutation);
           

            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static int updateCompanyContact(CompanyContact aCon)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_updateCompanyContact";
            SqlParameter[] sps = new SqlParameter[9];
            sps[0] = new SqlParameter("@companyId", aCon.companyId);
            sps[1] = new SqlParameter("@firstName", aCon.firstName);
            sps[2] = new SqlParameter("@lastName", aCon.lastName);
            sps[3] = new SqlParameter("@title", aCon.title);
            sps[4] = new SqlParameter("@extension", aCon.extension);
            sps[5] = new SqlParameter("@branch", aCon.branchId);
            sps[6] = new SqlParameter("@signature", aCon.signature);
            sps[7] = new SqlParameter("@salutation", aCon.salutation);

            sps[8] = new SqlParameter("@id", aCon.id);


            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static CompanyContact getContactById(int contactId)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_GetCompanyContactById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", contactId);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);

            CompanyContact aContact = new CompanyContact();
            aContact.id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            aContact.companyId = Convert.ToInt32(ds.Tables[0].Rows[0]["companyId"]);
            aContact.firstName = ds.Tables[0].Rows[0]["firstName"].ToString();
            aContact.lastName = ds.Tables[0].Rows[0]["lastName"].ToString();
            aContact.title = ds.Tables[0].Rows[0]["title"].ToString();
            aContact.extension = ds.Tables[0].Rows[0]["extension"].ToString();
            aContact.branchId = ds.Tables[0].Rows[0]["branch"].ToString();
            aContact.signature = ds.Tables[0].Rows[0]["signature"].ToString();
            aContact.salutation = ds.Tables[0].Rows[0]["salutation"].ToString();

            return aContact;
        }

        public static void deleteCompanyContact(int compId)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "sp_DeleteCompanyContact";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", compId);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }
    }
}
