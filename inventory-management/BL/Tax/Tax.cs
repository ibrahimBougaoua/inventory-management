using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Tax
{
    class Tax
    {
        public void add_Tax(string Name, decimal Tax)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Tax", SqlDbType.Float);
            param[1].Value = Tax;

            dal.excuteCommand("ADD_TAX", param);
            dal.Close();

        }
    }
}
