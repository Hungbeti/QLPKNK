﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Connection
    {
        private static SqlConnection conn;

        public static SqlConnection dbConnect()
        {
            if (conn == null)
            {
                string strcon = @"Data Source=DESKTOP-7SR6Q1U\SQLEXPRESS;Initial Catalog=QLPKNK;Integrated Security=True";
                conn = new SqlConnection(strcon);
            }
            return conn;
        }
    }
}
