using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示请假申请单
    /// </summary>
    public class TASheet
    {
        #region 构造函数
        public TASheet()
        {
        }
        #endregion

        #region 公共属性
        public Guid ID { get; set; }
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
        /// 获取或设置请假人员ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// 获取或设置申请人员
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 获取或设置部门
        /// </summary>
        public string Department { get; set; }
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
        public string CategoryID { get; set; }
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
    }
}
