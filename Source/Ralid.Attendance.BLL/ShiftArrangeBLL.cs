using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class ShiftArrangeBLL
    {
        #region 构造函数
        public ShiftArrangeBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<ShiftArrange> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(ShiftArrange info)
        {
            IShiftArrangeProvider provider = ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri);
            ShiftArrangeID id = new ShiftArrangeID(info.StaffID, info.ShiftID, info.ShiftDate);
            ShiftArrange item = provider.GetByID(id).QueryObject;
            if (item == null) 
            {
                IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
                provider.Insert(info, unitWork);
                return unitWork.Commit();
            }
            else //如果已经存在则直接返回
            {
                return new CommandResult(ResultCode.Successful, ResultCodeDecription.GetDescription(ResultCode.Successful));
            }
        }

        public CommandResult ShiftArrange(int userID, DatetimeRange range, List<ShiftArrange> arranges)
        {
            IShiftArrangeProvider provider = ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri);
            ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
            con.UserID = userID;
            con.ShiftDate = range;
            List<ShiftArrange> items = provider.GetItems(con).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (ShiftArrange item in items)
            {
                provider.Delete(item, unitWork);
            }
            if (arranges != null && arranges.Count > 0)
            {
                foreach (ShiftArrange item in arranges)
                {
                    provider.Insert(item, unitWork);
                }
            }
            return unitWork.Commit();
        }

        public CommandResult ShiftArrange(int userID, DateTime dt, List<Shift> shifts)
        {
            IShiftArrangeProvider provider = ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri);
            ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
            con.UserID = userID;
            con.ShiftDate = new DatetimeRange(dt, dt);
            List<ShiftArrange> items = provider.GetItems(con).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (ShiftArrange item in items)
            {
                provider.Delete(item, unitWork);
            }
            if (shifts != null && shifts.Count > 0)
            {
                foreach (Shift item in shifts)
                {
                    ShiftArrange sa = new Model.ShiftArrange()
                    {
                        StaffID = userID,
                        ShiftID = item.ID,
                        ShiftDate = dt
                    };
                    provider.Insert(sa, unitWork);
                }
            }
            return unitWork.Commit();
        }

        public CommandResult Delete(ShiftArrange info)
        {
            return ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri).Delete(info);
        }

        public CommandResult Delete(List<ShiftArrange> items)
        {
            IShiftArrangeProvider provider = ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri);
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            if (items != null && items.Count > 0)
            {
                foreach (ShiftArrange item in items)
                {
                    provider.Delete(item, unitWork);
                }
                return unitWork.Commit();
            }
            return new CommandResult(ResultCode.NoRecord, "没有记录");
        }

        public CommandResult ClearShiftArrange(int userID, DateTime dt)
        {
            IShiftArrangeProvider provider = ProviderFactory.Create<IShiftArrangeProvider>(_RepoUri);
            ShiftArrangeSearchCondition con = new ShiftArrangeSearchCondition();
            con.UserID = userID;
            con.ShiftDate = new DatetimeRange(dt, dt);
            List<ShiftArrange> items = provider.GetItems(con).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (ShiftArrange item in items)
            {
                provider.Delete(item, unitWork);
            }
            return unitWork.Commit();
        }
        #endregion
    }
}