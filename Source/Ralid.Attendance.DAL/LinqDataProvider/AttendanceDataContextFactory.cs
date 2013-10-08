using System.IO;
using System.Data.SqlClient ;
using System.Data.Linq.Mapping;
using Ralid.Attendance.Model;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    class AttendanceDataContextFactory
    {
        private static SqlConnection _Connection;

        public static AttendanceDataContext Createattendance(string connStr)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty(connStr), "没有找到有效的数据库连接!");
            Stream stream = typeof(AttendanceDataContextFactory).Assembly.GetManifestResourceStream("Ralid.Attendance.DAL.LinqDataProvider.DataMapping.xml");
            MappingSource mappingSource = XmlMappingSource.FromStream(stream);
            AttendanceDataContext attendance = new AttendanceDataContext(connStr, mappingSource);
            //attendance.Log = System.Console.Out;
            return attendance;
        }
    }
}
