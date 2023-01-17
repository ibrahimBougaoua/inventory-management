using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Warehouse
{
    class Warehouse
    {
        public void add_Warehouse(string Name,string Address,int City_ID, int Comm_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
            param[1].Value = Address;

            param[2] = new SqlParameter("@City_ID", SqlDbType.Int);
            param[2].Value = City_ID;

            param[3] = new SqlParameter("@Comm_ID", SqlDbType.Int);
            param[3].Value = Comm_ID;

            dal.excuteCommand("ADD_WAREHOUSE", param);
            dal.Close();
        }
    }
}
