using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Unit
{
    class Unit
    {
        public void add_Unit(string Code, string Unite)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Code", SqlDbType.NVarChar, 250);
            param[0].Value = Code;

            param[1] = new SqlParameter("@Unite", SqlDbType.NVarChar, 250);
            param[1].Value = Unite;

            dal.excuteCommand("ADD_UNIT", param);
            dal.Close();

        }
    }
}
