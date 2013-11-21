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
    public class DeviceGroupBLL
    {
        #region 构造函数
        public DeviceGroupBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<DeviceGroup> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(DeviceGroup info)
        {
            string id = ProviderFactory.Create<IStringIDCreater>(_RepoUri).CreateID("G", 3, "DeviceGroup");
            if (!string.IsNullOrEmpty(id))
            {
                info.ID = id;
                return ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).Insert(info);
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "创建ID失败");
            }
        }

        public CommandResult Update(DeviceGroup info)
        {
            DeviceGroup original = ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(DeviceGroup info)
        {
            List<DeviceGroup> depts = ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).GetItems(null).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (DeviceGroup dept in depts.Where(item => item.ID.IndexOf(info.ID, 0) == 0))
            {
                ProviderFactory.Create<IDeviceGroupProvider>(_RepoUri).Delete(dept, unitWork);
            }
            return unitWork.Commit();
        }
        #endregion
    }
}