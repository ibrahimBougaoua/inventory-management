using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace inventory_management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        
        //this constructor initialise the connection object 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS;Initial Catalog=Sales_System;Integrated Security=True");
        }

        // methode to open connection
        public void Open()
        {
            if(sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }


        // methode to close connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Methode to read Data from database
        public DataTable SelectData(string StoredProcedure, SqlParameter[] param = null)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = StoredProcedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        //Methode to read Data from database
        public string SelectSingleData(string StoredProcedure, SqlParameter[] param = null, string table = "")
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = StoredProcedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

            string data = sqlcmd.ExecuteScalar().ToString();

            return data;
        }
        //Methode to insert,Update and delete Data from database
        
        public int excuteCommand(string StoredProcedure, SqlParameter[] param,string table = "")
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = StoredProcedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
            
            string id = "-1";
            
            if (table == "product")
                id = sqlcmd.Parameters["@Pro_ID"].Value.ToString();
            else if(table == "order")
                id = sqlcmd.Parameters["@Order_ID"].Value.ToString();

            return Convert.ToInt32(id);
        }
    }
}
