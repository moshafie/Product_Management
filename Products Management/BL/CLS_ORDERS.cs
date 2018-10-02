using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return dt;
        }
        public DataTable GET_LAST_ORDER_ID_For_Print()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("GET_LAST_ORDER_ID_for_print", null);
            DAL.Close();
            return dt;
        }
        public void ADD_ORDER(int ID_order, DateTime DATE_ORDER, int CUSTOMER, string DESCRIPTION_ORDER, string SALES_MAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            param[0].Value = ID_order;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER", SqlDbType.Int);
            param[2].Value = CUSTOMER;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar,250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALES_MAN", SqlDbType.VarChar, 250);
            param[4].Value = SALES_MAN;


            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.Close();
        }

        public void ADD_ORDER_DETAILS(string IDPRODUCT, int ID_order, int QNT, string PRICE, float @DESCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,50);
            param[0].Value = IDPRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_order;

            param[2] = new SqlParameter("@QNT", SqlDbType.Int);
            param[2].Value = QNT;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DESCOUNT", SqlDbType.Float);
            param[4].Value = DESCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = TOTAL_AMOUNT;



            DAL.ExecuteCommand("ADD_ORDER_DETAILS", param);
            DAL.Close();
        }


        public DataTable VERIFY_QNT(string ID,int QNT_INTERED)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@QNT_INTERED", SqlDbType.Int);
            param[1].Value = QNT_INTERED;
            Dt = DAL.selectdata("VERIFY_QNT", param);
            DAL.Close();
            return Dt;
        }

        public DataTable SERCH_OREDERS(string SEARCH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            
            DataTable dt = new DataTable();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter("@GET_ORDERS", SqlDbType.VarChar, 50);
            PARAM[0].Value = SEARCH;

            dt = DAL.selectdata("SERCH_OREDERS", PARAM);
            DAL.Close();
            return dt;
        }

        public DataTable GET_ORDER_DETAILS_REPORT_forprint(int id_order)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter("@id_order", SqlDbType.Int);
            PARAM[0].Value = id_order;

            dt = DAL.selectdata("GET_ORDER_DETAILS_REPORT_forprint", PARAM);
            DAL.Close();
            return dt;
        }

    }
}