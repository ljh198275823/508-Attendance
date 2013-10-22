using System.IO;
using System.Data;
using System.Data.SqlClient ;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using LJH.Attendance.Model;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    class AttendanceDataContextFactory
    {
        public static AttendanceDataContext Createattendance(string connStr)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty(connStr), "没有找到有效的数据库连接!");
            IDbConnection connection = null;
            Stream stream = typeof(AttendanceDataContextFactory).Assembly.GetManifestResourceStream("LJH.Attendance.DAL.LinqDataProvider.DataMapping.xml");
            XmlMappingSource mappingSource = XmlMappingSource.FromStream(stream);
            int p = connStr.IndexOf(':');
            if (p > 0)
            {
                string sqlType = connStr.Substring(0, p);
                if (sqlType.ToUpper() == "MSSQL")
                {
                    connection = new SqlConnection(connStr.Substring(p + 1));
                }
                else if (sqlType.ToUpper() == "SQLITE")
                {
                    connection = new SQLiteConnection(connStr.Substring(p + 1));
                }
            }
            System.Diagnostics.Debug.Assert(connection != null, "没有找到有效的数据库连接!");
            AttendanceDataContext attendance = new AttendanceDataContext(connection, mappingSource);
            //attendance.Log = System.Console.Out;
            return attendance;
        }
    }
}
