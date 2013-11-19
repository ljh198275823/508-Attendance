using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class DeviceInfoBLL
    {
        #region 构造函数
        public DeviceInfoBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<DeviceInfo> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).GetItems(con);
        }

        public QueryResultList<DeviceInfo> GetAttendanceReaders()
        {
            QueryResultList<DeviceInfo> ret = ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).GetItems(null);
            List<DeviceInfo> items = ret.QueryObjects;
            if (items != null && items.Count > 0)
            {
                items = items.Where(item => item.ForAttendance).ToList();
            }
            return new QueryResultList<DeviceInfo>(ret.Result, items);
        }

        public CommandResult Add(DeviceInfo info)
        {
            string id = ProviderFactory.Create<IStringIDCreater>(_RepoUri).CreateID("0", 4, "Reader");
            if (!string.IsNullOrEmpty(id))
            {
                info.ID = id;
                return ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).Insert(info);
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "创建ID失败");
            }
        }

        public CommandResult Update(DeviceInfo info)
        {

            DeviceInfo original = ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(DeviceInfo info)
        {
            return ProviderFactory.Create<IDeviceInfoProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}
