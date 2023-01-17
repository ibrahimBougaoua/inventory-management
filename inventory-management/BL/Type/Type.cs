using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management.BL.Type
{
    class Type
    {
        public void add_Product_Type(string Type)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[0].Value = Type;

            dal.excuteCommand("ADD_PRODUCT_TYPE", param);
            dal.Close();
        }
    }
}
