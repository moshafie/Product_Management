using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Products_Management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
       
        //this constructor inisialize the connection object

       
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.MODE;
            if (mode=="sql")
            {
                sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER + 
                    "; Database=" + Properties.Settings.Default.DATABASE +
                    "; integrated security=false;userid="+Properties.Settings.Default.USERID+
                    "password="+Properties.Settings.Default.PASSWORD+"");
            }
            else
            {
                sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER + "; Database=" + Properties.Settings.Default.DATABASE + "; integrated security=true");
            }
           
        }

        //method to open the connection

        public void Open()
        {

            if (sqlconnection.State != ConnectionState.Open) 
            {


                sqlconnection.Open();
            
            }
        
        }

        //method to close the connection
       
        public void Close()
        {

            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        
        
        }


        //method to read data from database

        public DataTable selectdata(string stored_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {

                for (int i = 0; i < param.Length; i++)
                {

                    sqlcmd.Parameters.Add(param[i]);
                }

            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //method to insert, update , and delete data from database
        public void ExecuteCommand(string stord_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stord_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {

                sqlcmd.Parameters.AddRange(param);

            }
            sqlcmd.ExecuteNonQuery();

        
        }

    }
}
