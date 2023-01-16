﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Category
{
    class Category
    {
        public void add_category(string Name, string Tax)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Tax", SqlDbType.NVarChar, 250);
            param[1].Value = Tax;

            dal.excuteCommand("ADD_CATEGORY", param);
            dal.Close();

        }
    }
}
