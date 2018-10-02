using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Products_Management.BL
{
    class CLS_LOGIN
    {

        public DataTable LOGIN(string ID, string PWD)
        {
            

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value =PWD;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("SP_Login", param);
            DAL.Close();
            return Dt;
        }
        public void ADD_NEW_USER(string USERID, string USERPASSWORED, string USERTYP, string USERNAME)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@USER_ID", SqlDbType.VarChar, 50);
            param[0].Value = USERID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = USERPASSWORED;

            param[2] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[2].Value = USERTYP;

            param[3] = new SqlParameter("@USERNAME", SqlDbType.NVarChar,50);
            param[3].Value = USERNAME;



            DAL.ExecuteCommand("ADD_NEW_USER", param);
            DAL.Close();
        }

        public DataTable SEARCHUSER(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter("@SEARCH", SqlDbType.VarChar, 50);
            PARAM[0].Value = SEARCH;

            dt = DAL.selectdata("SEARCHUSER", PARAM);
            DAL.Close();
            return dt;
        }


        public void UPDATE_USER(string USERID, string USERPASSWORED, string USERTYP, string USERNAME)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = USERID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = USERPASSWORED;

            param[2] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[2].Value = USERTYP;

            param[3] = new SqlParameter("@USERNAME", SqlDbType.NVarChar, 50);
            param[3].Value = USERNAME;



            DAL.ExecuteCommand("UPDATE_USER", param);
            DAL.Close();
        }
        public void DELETEUSER(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("DELETEUSER", param);
            DAL.Close();
        }
    }
}
