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
            string sqlType = AppSettings.CurrentSetting.GetSQLType();
            if (sqlType == "MSSQL")
            {
                connection = new SqlConnection(AppSettings.CurrentSetting.GetConnectString());
            }
            else if (sqlType == "SQLITE")
            {
                connection = new SQLiteConnection(AppSettings.CurrentSetting.GetConnectString());
            }
            System.Diagnostics.Debug.Assert(connection != null, "没有找到有效的数据库连接!");
            AttendanceDataContext attendance = new AttendanceDataContext(connection, mappingSource);
            //attendance.Log = System.Console.Out;
            return attendance;
        }
    }
}
