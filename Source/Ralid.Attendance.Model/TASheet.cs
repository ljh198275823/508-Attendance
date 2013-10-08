using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
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

        #region 私有变量
        private string _StartTime;
        private string _EndTime;
        #endregion

        #region 公共属性
        public int ID { get; set; }
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
        public int StaffID { get; set; }
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
        /// 获取或设置开始时间
        /// </summary>
        public MyTime StartTime
        {
            get
            {
                if (_StartTime != null && _StartTime.Length == 6)
                {
                    int hour = 0;
                    int minute = 0;
                    int second = 0;
                    if (int.TryParse(_StartTime.Substring(0, 2), out hour) &&
                        int.TryParse(_StartTime.Substring(2, 2), out minute) &&
                        int.TryParse(_StartTime.Substring(4, 2), out second))
                    {
                        return new MyTime(hour, minute, second);
                    }
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    _StartTime = null;
                }
                else
                {
                    _StartTime = value.ToShortString();
                }
            }
        }
        /// <summary>
        /// 获取或设置结束时间
        /// </summary>
        public MyTime EndTime
        {
            get
            {
                if (_EndTime != null && _EndTime.Length == 6)
                {
                    int hour = 0;
                    int minute = 0;
                    int second = 0;
                    if (int.TryParse(_EndTime.Substring(0, 2), out hour) &&
                        int.TryParse(_EndTime.Substring(2, 2), out minute) &&
                        int.TryParse(_EndTime.Substring(4, 2), out second))
                    {
                        return new MyTime(hour, minute, second);
                    }
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    _EndTime = null;
                }
                else
                {
                    _EndTime = value.ToShortString();
                }
            }
        }
        /// <summary>
        /// 获取或设置计时时长(分)
        /// </summary>
        public int Duration { get; set; }
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
        #endregion
    }
}
