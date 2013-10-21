using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using System;
using LJH.Attendance.Model;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class AttendanceDataContext : System.Data.Linq.DataContext
    {
        public AttendanceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
        }

        public AttendanceDataContext(IDbConnection connect, System.Data.Linq.Mapping.MappingSource mappingSource)
            : base(connect, mappingSource)
        {
        }

        public AttendanceDataContext(IDbConnection connect)
            : base(connect)
        {
        }
    }
}