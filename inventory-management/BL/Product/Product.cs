using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Product
{
    class Product
    {
        public void add_Product(
            string Pro_Name,
            string Ref,
            int Box,
            Decimal Box_Price,
            int Qty_Alert,
            DateTime Production_Date,
            DateTime Expiration_Date,
            DateTime Waiting_period,
            int Tax_ID ,
            int Ut_ID ,
            int Cate_ID ,
            int Fm_ID ,
            int Brand_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar, 250);
            param[0].Value = Pro_Name;

            param[1] = new SqlParameter("@Ref", SqlDbType.NVarChar, 50);
            param[1].Value = Ref;

            param[2] = new SqlParameter("@Box", SqlDbType.Int);
            param[2].Value = Box;

            param[3] = new SqlParameter("@Box_Price", SqlDbType.Decimal);
            param[3].Value = Box_Price;

            param[4] = new SqlParameter("@Qty_Alert", SqlDbType.Int);
            param[4].Value = Qty_Alert;

            param[5] = new SqlParameter("@Production_Date", SqlDbType.DateTime);
            param[5].Value = Production_Date;

            param[6] = new SqlParameter("@Expiration_Date", SqlDbType.DateTime);
            param[6].Value = Expiration_Date;

            param[7] = new SqlParameter("@Waiting_period", SqlDbType.DateTime);
            param[7].Value = Waiting_period;

            param[8] = new SqlParameter("@Tax_ID", SqlDbType.Int);
            param[8].Value = Tax_ID;

            param[9] = new SqlParameter("@Ut_ID", SqlDbType.Int);
            param[9].Value = Ut_ID;

            param[10] = new SqlParameter("@Cate_ID", SqlDbType.Int);
            param[10].Value = Cate_ID;

            param[11] = new SqlParameter("@Fm_ID", SqlDbType.Int);
            param[11].Value = Fm_ID;

            param[12] = new SqlParameter("@Brand_ID", SqlDbType.Int);
            param[12].Value = Brand_ID;

            dal.excuteCommand("ADD_PRODUCT", param);
            dal.Close();

        }
    }
}
