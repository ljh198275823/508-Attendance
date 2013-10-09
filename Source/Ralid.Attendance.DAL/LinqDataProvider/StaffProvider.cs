using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public class StaffProvider : ProviderBase<Staff, int>, IStaffProvider
    {
        #region 构造函数
        public StaffProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override Staff GetingItemByID(int id, AttendanceDataContext attendance)
        {
            Staff staff = attendance.GetTable<Staff>().SingleOrDefault(item => item.ID == id);
            T_StaffDepartmentPair pair = attendance.GetTable<T_StaffDepartmentPair>().SingleOrDefault(item => item.StaffID == id);
            if (pair != null) staff.DepartmentID = pair.DepartmentID;
            return staff;
        }

        protected override List<Staff> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<Staff> ret = attendance.GetTable<Staff>();

            List<Staff> items = ret.ToList();
            if (items != null && items.Count > 0)
            {
                List<T_StaffDepartmentPair> pairs = attendance.GetTable<T_StaffDepartmentPair>().ToList();
                foreach (Staff item in items)
                {
                    T_StaffDepartmentPair pair = pairs.FirstOrDefault(it => it.StaffID == item.ID);
                    if (pair != null) item.DepartmentID = pair.DepartmentID;
                }
            }
            return items;
        }

        protected override void InsertingItem(Ralid.Attendance.Model.Staff info, Ralid.Attendance.DAL.LinqDataProvider.AttendanceDataContext attendance)
        {
            throw new InvalidOperationException("增加人员的功能未实现");
        }

        protected override void UpdatingItem(Staff newVal, Staff original, AttendanceDataContext attendance)
        {
            if (newVal.DepartmentID != original.DepartmentID)
            {
                T_StaffDepartmentPair pair = attendance.GetTable<T_StaffDepartmentPair>().SingleOrDefault(item => item.StaffID == newVal.ID);
                if (string.IsNullOrEmpty(newVal.DepartmentID)) //如果当前人员部门为空，则删除
                {
                    if (pair != null) attendance.GetTable<T_StaffDepartmentPair>().DeleteOnSubmit(pair);
                }
                else
                {
                    if (pair == null)
                    {
                        pair = new T_StaffDepartmentPair() { StaffID = newVal.ID, DepartmentID = newVal.DepartmentID };
                        attendance.GetTable<T_StaffDepartmentPair>().InsertOnSubmit(pair);
                    }
                    else
                    {
                        pair.DepartmentID = newVal.DepartmentID;
                    }
                }
            }
            if (newVal.Resigned != original.Resigned)
            {
                if (newVal.Resigned)
                {
                    T_ResignStaff rs = new T_ResignStaff() { StaffID = newVal.ID };
                    attendance.GetTable<T_ResignStaff>().InsertOnSubmit(rs);
                }
                else
                {
                    T_ResignStaff rs = new T_ResignStaff() { StaffID = newVal.ID };
                    attendance.GetTable<T_ResignStaff>().Attach(rs);
                    attendance.GetTable<T_ResignStaff>().DeleteOnSubmit(rs);
                }
            }
        }

        protected override void DeletingItem(Staff info, AttendanceDataContext attendance)
        {
            throw new InvalidOperationException("删除人员的功能未实现");
        }
        #endregion
    }
}
