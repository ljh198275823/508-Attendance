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
    public class ShiftTemplateProvider : ProviderBase<ShiftTemplate, int>, IShiftTemplateProvider
    {
        #region 构造函数
        public ShiftTemplateProvider(string connStr)
            : base(connStr)
        {
        }
        #endregion

        #region 重写基类方法
        protected override ShiftTemplate GetingItemByID(int id, AttendanceDataContext attendance)
        {
            T_ShiftArrangeTemplate tst= attendance.GetTable<T_ShiftArrangeTemplate>().SingleOrDefault(item => item.ID == id);
            if (tst != null) return T_ShiftArrangeTemplate.Create(tst);
            return null;
        }

        protected override List<ShiftTemplate> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<T_ShiftArrangeTemplate> ret = attendance.GetTable<T_ShiftArrangeTemplate>();
            List<T_ShiftArrangeTemplate> items = ret.ToList();

            List<ShiftTemplate> templates = new List<ShiftTemplate>();
            if (items != null && items.Count > 0)
            {
                foreach (T_ShiftArrangeTemplate item in items)
                {
                    templates.Add(T_ShiftArrangeTemplate.Create(item));
                }
            }
            return templates;
        }

        protected override void InsertingItem(ShiftTemplate info, AttendanceDataContext attendance)
        {
            attendance.GetTable<T_ShiftArrangeTemplate>().InsertOnSubmit(T_ShiftArrangeTemplate.Create(info));
        }

        protected override void UpdatingItem(ShiftTemplate newVal, ShiftTemplate original, AttendanceDataContext attendance)
        {
            attendance.GetTable<T_ShiftArrangeTemplate>().Attach(T_ShiftArrangeTemplate.Create(newVal), T_ShiftArrangeTemplate.Create(original));
        }

        protected override void DeletingItem(ShiftTemplate info, AttendanceDataContext attendance)
        {
            T_ShiftArrangeTemplate item = T_ShiftArrangeTemplate.Create(info);
            attendance.GetTable<T_ShiftArrangeTemplate>().Attach(item);
            attendance.GetTable<T_ShiftArrangeTemplate>().DeleteOnSubmit(item);
        }
        #endregion
    }
}

