using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management.BL.Order
{
    class Order
    {
        public string get_orders_total()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@total", SqlDbType.Real);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_ORDERS_TOTAL_PRICE", param,"total_price");
            dal.Close();

            return id;
        }
    }
}
