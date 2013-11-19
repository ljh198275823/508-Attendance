using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class DeviceInfoProvider : ProviderBase<DeviceInfo, string>, IDeviceInfoProvider
    {
        #region 构造函数
        public DeviceInfoProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override DeviceInfo GetingItemByID(string id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<DeviceInfo>().SingleOrDefault(item => item.ID == id);
        }
        #endregion
    }
}
