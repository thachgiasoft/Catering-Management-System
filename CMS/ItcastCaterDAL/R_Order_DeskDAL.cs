﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ItcastCater.Model;

namespace ItcastCater.DAL
{
    public class R_Order_DeskDAL
    {
        /// <summary>
        /// 添加一个中间表的数据
        /// </summary>
        /// <param name="rod"></param>
        /// <returns></returns>
        public int AddROrderDesk(R_Order_Desk rod)
        {
            string sql = "insert into R_Order_Desk (OrderId,DeskId) values(@OrderId,@DeskId)";
            return SqliteHelper.ExecuteNonQuery(sql, new SQLiteParameter("@OrderId", rod.OrderId), new SQLiteParameter("@DeskId", rod.DeskId));
        }
    }
}
