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
            if (staff != null && !string.IsNullOrEmpty(staff.DepartmentID))
            {
                staff.Department = (new DepartmentProvider(ConnectStr)).GetByID(staff.DepartmentID).QueryObject;
            }
            return staff;
        }

        protected override List<Staff> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<Staff> ret = attendance.GetTable<Staff>();
            List<Staff> items = ret.ToList();
            if (items != null)
            {
                List<Department> depts = (new DepartmentProvider(ConnectStr)).GetItems(null).QueryObjects;
                if (depts != null && depts.Count > 0)
                {
                    foreach (Staff staff in items)
                    {
                        if (!string.IsNullOrEmpty(staff.DepartmentID)) staff.Department = depts.SingleOrDefault(dept => staff.DepartmentID == dept.ID);
                    }
                }
            }
            return items;
        }

        protected override void InsertingItem(LJH.Attendance.Model.Staff info, LJH.Attendance.DAL.LinqDataProvider.AttendanceDataContext attendance)
        {
            long? id = (new IntegerIDCreater(ConnectStr)).CreateID("Staff");
            if (id != null)
            {
                info.ID = (int)id.Value;
                base.InsertingItem(info, attendance);
            }
        }
        #endregion
    }
}
