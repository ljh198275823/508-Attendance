using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class IntegerIDCreater : IIntegerCreater
    {
        #region 构造函数
        public IntegerIDCreater(string connStr)
        {
            _ConnStr = connStr;
        }
        #endregion

        #region 私有变量
        private string _ConnStr;
        #endregion

        #region 实现接口IIntegerCreater
        public long? CreateID(string entity)
        {
            long? id = null;
            AttendanceDataContext dc = AttendanceDataContextFactory.Createattendance(_ConnStr);
            IntegerID ii = dc.GetTable<IntegerID>().SingleOrDefault(item => item.Entity == entity);
            if (ii == null)
            {
                ii = new IntegerID() { Entity = entity, Value = 2 };
                dc.GetTable<IntegerID>().InsertOnSubmit(ii);
                dc.SubmitChanges();
                id = 1;
            }
            else
            {
                id = ii.Value;
                ii.Value += 1;
                dc.SubmitChanges();
            }
            return id;
        }

        public long? GetCurID(string entity)
        {
            long? id = null;
            AttendanceDataContext dc = AttendanceDataContextFactory.Createattendance(_ConnStr);
            IntegerID ii = dc.GetTable<IntegerID>().SingleOrDefault(item => item.Entity == entity);
            if (ii != null)
            {
                id = ii.Value;
            }
            return id;
        }

        public void ResetID(string entity, long id)
        {
            try
            {
                AttendanceDataContext dc = AttendanceDataContextFactory.Createattendance(_ConnStr);
                IntegerID ii = dc.GetTable<IntegerID>().SingleOrDefault(item => item.Entity == entity);
                if (ii == null)
                {
                    ii = new IntegerID() { Entity = entity, Value = id };
                    dc.GetTable<IntegerID>().InsertOnSubmit(ii);
                    dc.SubmitChanges();
                }
                else
                {
                    ii.Value = id;
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
        }
        #endregion
    }

    internal class IntegerID
    {
        public string Entity { get; set; }

        public long Value { get; set; }
    }
}
