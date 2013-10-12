using System.IO;
using System.Data.SqlClient ;
using System.Data.Linq.Mapping;
using LJH.Attendance.Model;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    class AttendanceDataContextFactory
    {
        private static SqlConnection _Connection;

        public static AttendanceDataContext Createattendance(string connStr)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty(connStr), "没有找到有效的数据库连接!");
            Stream stream = typeof(AttendanceDataContextFactory).Assembly.GetManifestResourceStream("LJH.Attendance.DAL.LinqDataProvider.DataMapping.xml");
            MappingSource mappingSource = XmlMappingSource.FromStream(stream);
            AttendanceDataContext attendance = new AttendanceDataContext(connStr, mappingSource);
            //attendance.Log = System.Console.Out;
            return attendance;
        }
    }
}
