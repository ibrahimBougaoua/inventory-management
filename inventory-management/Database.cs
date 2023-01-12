using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace inventory_management
{
    class Database
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Sales_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public DataTable readData(string stmt, string message)
        {
            DataTable table = new DataTable();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                table.Load(cmd.ExecuteReader());
                conn.Close();
                if (message != "")
                    MessageBox.Show(message, "Confirmer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return table;
        }

        public bool exceuteData(string stmt,string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message != "")
                    MessageBox.Show(message, "Confirmer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
