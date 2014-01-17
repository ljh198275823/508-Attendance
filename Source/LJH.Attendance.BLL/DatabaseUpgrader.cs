using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.GeneralLibrary.SQLHelper;

namespace LJH.Attendance.BLL
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
                SqlClient client = new SqlClient(repoUri);
                client.Connect();
                client.ExecuteSQLFile(path);
                ret = true;
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return ret;
        }
    }
}
