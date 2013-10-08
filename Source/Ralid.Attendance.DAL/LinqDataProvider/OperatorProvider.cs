using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using Ralid.Attendance.DAL.IDAL;
using Ralid.Attendance.Model;
using Ralid.Attendance .Model.SearchCondition;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public class OperatorProvider : ProviderBase<Operator, string>, IOperatorProvider
    {
        public OperatorProvider()
        {
        }

        public OperatorProvider(string connStr)
            : base(connStr)
        {
        }

        #region 重写模板方法
        protected override Operator GetingItemByID(string id, AttendanceDataContext attendance)
        {
            Operator opt = attendance.Operator.SingleOrDefault(o => o.ID == id);
            if (opt != null)
            {
                opt.Role = attendance.GetTable<Role>().SingleOrDefault(item => item.ID == opt.RoleID);
                if (!opt.IsAdmin) opt.Depts = attendance.GetTable<T_OperatorDept>().Where(item => item.OperatorID == id).Select(item => item.DepartmentID).ToList();
            }
            return opt;
        }

        protected override List<Operator> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<Operator> ret = attendance.GetTable<Operator>();
            if (search == null)
            {
            }
            List<Operator> items = ret.ToList();
            if (items != null && items.Count > 0)
            {
                List<Role> roles = attendance.GetTable<Role>().ToList();
                List<T_OperatorDept> optDepts = attendance.GetTable<T_OperatorDept>().ToList();
                foreach (Operator opt in items)
                {
                    opt.Role = roles.SingleOrDefault(role => role.ID == opt.RoleID);
                    if (!opt.IsAdmin) opt.Depts = optDepts.Where(item => item.OperatorID == opt.ID).Select(item => item.DepartmentID).ToList();
                }
            }
            return items;
        }

        protected override void InsertingItem(Operator info, Ralid.Attendance.DAL.LinqDataProvider.AttendanceDataContext attendance)
        {
            attendance.GetTable<Operator>().InsertOnSubmit(info);
            List<T_OperatorDept> optDepts = attendance.GetTable<T_OperatorDept>().Where(item => item.OperatorID == info.ID).ToList();
            attendance.GetTable<T_OperatorDept>().DeleteAllOnSubmit(optDepts);
            if (!info.IsAdmin)
            {
                foreach (string item in info.Depts)
                {
                    if (!optDepts.Exists(it => it.DepartmentID == item))
                    {
                        attendance.GetTable<T_OperatorDept>().InsertOnSubmit(new T_OperatorDept() { OperatorID = info.ID, DepartmentID = item });
                    }
                }
                foreach (T_OperatorDept item in optDepts)
                {
                    if (!info.Depts.Exists(it => it == item.DepartmentID))
                    {
                        attendance.GetTable<T_OperatorDept>().DeleteOnSubmit(item);
                    }
                }
            }
        }

        protected override void UpdatingItem(Operator newVal, Operator original, AttendanceDataContext attendance)
        {
            attendance.GetTable<Operator>().Attach(newVal, original);
            List<T_OperatorDept> optDepts = attendance.GetTable<T_OperatorDept>().Where(item => item.OperatorID == newVal.ID).ToList();
            if (!newVal.IsAdmin)
            {
                foreach (string item in newVal.Depts)
                {
                    if (!optDepts.Exists(it => it.DepartmentID == item))
                    {
                        attendance.GetTable<T_OperatorDept>().InsertOnSubmit(new T_OperatorDept() { OperatorID = newVal.ID, DepartmentID = item });
                    }
                }
                foreach (T_OperatorDept item in optDepts)
                {
                    if (!newVal.Depts.Exists(it => it == item.DepartmentID))
                    {
                        attendance.GetTable<T_OperatorDept>().DeleteOnSubmit(item);
                    }
                }
            }
        }

        protected override void DeletingItem(Operator info, AttendanceDataContext attendance)
        {
            attendance.GetTable<Operator>().Attach(info);
            attendance.GetTable<Operator>().DeleteOnSubmit(info);
            List<T_OperatorDept> optDepts = attendance.GetTable<T_OperatorDept>().Where(item => item.OperatorID == info.ID).ToList();
            attendance.GetTable<T_OperatorDept>().DeleteAllOnSubmit(optDepts);
        }
        #endregion
    }
}
