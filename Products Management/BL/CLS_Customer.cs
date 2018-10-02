using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_Customer
    {

        public DataTable select_customer()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt=DAL.selectdata("get_customer", null);
            DAL.Close();
            return dt;
        }


        public void ADD_NEW_CUSTOMER (string FIRST_NAME,string LAST_NAME,string TEL,string EMAIT,byte[]IMAGE,string critarion)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param= new  SqlParameter[6];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar,50);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 50);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 11);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar);
            param[3].Value = EMAIT;

            param[4] = new SqlParameter("IMAGE_CUSTOMER", SqlDbType.Image);
            param[4].Value = IMAGE;

            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = critarion;

            DAL.ExecuteCommand("ADD_NEW_CUSTOMER", param);
            DAL.Close();    
      }


        public void UBDATE_CUSTOMER(int ID, string FIRST_NAME, string LAST_NAME, string TEL, string EMAIT, byte[] IMAGE, string critarion)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0]=new SqlParameter("@ID_CUSTOMER",SqlDbType.Int);
            param[0].Value=ID;

            param[1] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 50);
            param[1].Value = FIRST_NAME;

            param[2] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 50);
            param[2].Value = LAST_NAME;

            param[3] = new SqlParameter("@TEL", SqlDbType.NChar, 11);
            param[3].Value = TEL;

            param[4] = new SqlParameter("@EMAIL", SqlDbType.VarChar);
            param[4].Value = EMAIT;

            param[5] = new SqlParameter("@IMAGE", SqlDbType.Image);
            param[5].Value = IMAGE;

            param[6] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[6].Value = critarion;

            DAL.ExecuteCommand("UPDATE_CUSTOMER", param);
            DAL.Close();
        }

        public void delete_customer (int ID)
        
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("delete_customer", param);
            DAL.Close();
        }
        public DataTable search_customer(string creation)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@creation", SqlDbType.VarChar);
            param[0].Value = creation;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("Search_customer", param);
            DAL.Close();
            return dt;
        }

}
}
