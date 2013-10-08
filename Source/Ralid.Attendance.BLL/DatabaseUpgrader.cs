﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;

namespace Ralid.Attendance.BLL
{
    /// <summary>
    /// 用于数据库升级的类
    /// </summary>
    public class DatabaseUpgrader
    {
        public static bool ExeSQLFile(string repoUri, string path)
        {
            bool ret = false;
            try
            {
                SqlClientHelper.SqlClient client = new SqlClientHelper.SqlClient(repoUri);
                client.Connect();
                client.ExecuteSQLFile(path);
                ret = true;
            }
            catch (Exception ex)
            {
                Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return ret;
        }
    }
}
