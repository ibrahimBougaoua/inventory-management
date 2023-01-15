using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL
{
    class Deserved
    {
        public void add_Deserved(string Des_id,float Price,DateTime Datetime,string Notes,int typeDes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Des_ID", SqlDbType.Int);
            param[0].Value = Des_id;
            
            param[1] = new SqlParameter("@Price", SqlDbType.Float);
            param[1].Value = Price;

            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Datetime;

            param[3] = new SqlParameter("@Notes", SqlDbType.NVarChar,50);
            param[3].Value = Notes;

            param[4] = new SqlParameter("@Type_ID", SqlDbType.Int);
            param[4].Value = typeDes;

            dal.excuteCommand("ADD_DESERVED",param);
            dal.Close();

        }
    }
}
