using System.Data.Linq;
using System.Data.Linq.Mapping;
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

        public System.Data.Linq.Table<Operator> Operator
        {
            get
            {
                return this.GetTable<Operator>();
            }
        }

        public System.Data.Linq.Table<Role> Role
        {
            get
            {
                return this.GetTable<Role>();
            }
        }
    }
}