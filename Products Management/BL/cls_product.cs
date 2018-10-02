using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Products_Management.BL
{
    class cls_product
    {

        public DataTable GET_ALL_CATEGORIES()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }
 //string LABEL_PRODUCT


        public void ADD_PRODUCT(int ID_CAT, string LABEL_PRODUCT, string ID_PRODUCT, int QTE_IN_STOCK, string PRICE, byte[] img)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,50);
            param[1].Value = ID_PRODUCT;

            param[2] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 50);
            param[2].Value = LABEL_PRODUCT;

            param[3] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[3].Value = QTE_IN_STOCK;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@IMAGE_Products", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.Close();
        }

        public DataTable VERIVY_IDPRODUCT(string ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.selectdata("VERIVY_IDPRODUCT", param);
            DAL.Close();
            return Dt;
        }


        public DataTable GET_ALL_PRODUCTS()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return Dt;
        }

        public DataTable search_PRODUCT(string ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.selectdata("search_PRODUCT", param);
            DAL.Close();
            return Dt;
        }

        public void Delete_Product(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Product", param);
            DAL.Close(); 
        }

        public void UbDate_PRODUCT(int ID_CAT, string LABEL_PRODUCT, string ID, int QTE_IN_STOCK, string PRICE, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@ID_Product", SqlDbType.VarChar,50);
            param[1].Value = ID;

            param[2] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 50);
            param[2].Value = LABEL_PRODUCT;

            param[3] = new SqlParameter("@QTE_IN_STOCK", SqlDbType.Int);
            param[3].Value = QTE_IN_STOCK;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@IMAGE_Products",SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("UbDate_PRODUCT", param);
            DAL.Close();
        }
     
        public DataTable Get_Imag(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,(50));
            param[0].Value = ID;

            dt = DAL.selectdata("Get_Imag",param);
            DAL.Close();
            return dt;
        }

    }
}
