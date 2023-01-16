﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inventory_management.BL.Task
{
    class Task
    {
        public void add_Task(string Name)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            dal.excuteCommand("ADD_TASK", param);
            dal.Close();

        }
    }
}
