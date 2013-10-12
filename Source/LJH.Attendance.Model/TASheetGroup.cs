using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class TASheetGroup
    {
        #region 静态方法
        public static List<TASheetGroup> Group(List<TASheet> sheets)
        {
            List<TASheetGroup> items = null;
            if (sheets != null && sheets.Count > 0)
            {
                foreach (TASheet sheet in sheets)
                {
                    if (items == null) items = new List<TASheetGroup>();
                    TASheetGroup item = items.SingleOrDefault(it => it.SheetID == sheet.SheetID);
                    if (item == null)
                    {
                        item = new TASheetGroup()
                        {
                            SheetID = sheet.SheetID,
                            SheetType = sheet.SheetType,
                            CreateDate = sheet.CreateDate,
                            StartDate = sheet.StartDate,
                            EndDate = sheet.EndDate,
                            Items = sheet.Items,
                            Category = sheet.CategoryID,
                            Header = sheet.Header,
                            Manager = sheet.Manager,
                            HR = sheet.HR,
                            Memo = sheet.Memo,
                            Staff = new List<Staff>()
                        };
                        items.Add(item);
                    }
                    item.Staff.Add(new Staff() { ID = sheet.StaffID, Name = sheet.StaffName });
                }
            }
            return items;
        }

        public static List<TASheet> UnGroup(TASheetGroup group)
        {
            List<TASheet> items = null;
            if (group.Staff != null && group.Staff.Count > 0)
            {
                items = new List<TASheet>();
                foreach (Staff staff in group.Staff)
                {
                    TASheet item = new TASheet()
                      {
                          SheetID = group.SheetID,
                          SheetType = group.SheetType,
                          CreateDate = group.CreateDate,
                          StartDate = group.StartDate,
                          EndDate = group.EndDate,
                          Items = group.Items,
                          CategoryID = group.Category,
                          StaffID = staff.ID,
                          StaffName = staff.Name,
                          Header = group.Header,
                          Manager = group.Manager,
                          HR = group.HR,
                          Memo = group.Memo,
                      };
                    items.Add(item);
                }
            }
            return items;
        }
        #endregion

        #region 构造函数
        public TASheetGroup()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置单据ID
        /// </summary>
        public Guid SheetID { get; set; }
        /// <summary>
        /// 获取或设置单据类别(‘A’表示加班单，‘B’表示请假单，‘C’表示外出出差单
        /// </summary>
        public string SheetType { get; set; }
        /// <summary>
        /// 获取或设置创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 获取或设置人员列表
        /// </summary>
        public List<Staff> Staff { get; set; }
        /// <summary>
        /// 获取或设置开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 获取或设置结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 获取或设置类别
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 获取或设置部门主管签名
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// 获取或设置经理签名
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// 获取或设置人事签名
        /// </summary>
        public string HR { get; set; }
        /// <summary>
        /// 获取或设置请假事由
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 获取或设置时间段列表
        /// </summary>
        public List<TASheetItem> Items { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取所有人员姓名的列表，各个人名之前以split分隔
        /// </summary>
        /// <param name="split"></param>
        /// <returns></returns>
        public string GetStaffNameString(string split)
        {
            if (Staff != null && Staff.Count > 0)
            {
                string temp = string.Empty;
                for (int i = 0; i < Staff.Count; i++)
                {
                    if (i == 0) temp = Staff[i].Name;
                    else
                    {
                        temp += split + Staff[i].Name;
                    }
                }
                return temp;
            }
            return string.Empty;
        }
        #endregion
    }
}
