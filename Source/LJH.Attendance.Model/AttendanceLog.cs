using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class AttendanceLog
    {
        #region 构造函数
        public AttendanceLog()
        {
        }
        #endregion

        #region 公共属性
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置考勤记录的人员ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// 获取或设置考勤记录的人员姓名
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 获取或设置考勤时间
        /// </summary>
        public DateTime ReadDateTime { get; set; }
        /// <summary>
        /// 获取或设置考勤点
        /// </summary>
        public string ReaderID { get; set; }
        /// <summary>
        /// 获取或设置考勤点名称
        /// </summary>
        public string ReaderName { get; set; }
        /// <summary>
        /// 获取或设置记录是否是人工签卡
        /// </summary>
        public bool IsManual { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
