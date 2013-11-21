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
    public class DeviceGroupProvider : ProviderBase<DeviceGroup, string>, IDeviceGroupProvider
    {
        #region 构造函数
        public DeviceGroupProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override DeviceGroup GetingItemByID(string id, AttendanceDataContext attendance)
        {
            return attendance.GetTable<DeviceGroup>().SingleOrDefault(item => item.ID == id);
        }
        #endregion
    }
}
