using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁刷卡器
    /// </summary>
    public class Reader
    {
        #region 构造函数
        public Reader()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置设备类型
        /// </summary>
        public byte DeviceType { get; set; }
        /// <summary>
        /// 获取或设置IP
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 获取或设置子网掩码
        /// </summary>
        public string IPMask { get; set; }
        /// <summary>
        /// 获取或设置网关
        /// </summary>
        public string Gateway { get; set; }
        /// <summary>
        /// 获取或设置控制端口号
        /// </summary>
        public int ControlPort { get; set; }
        /// <summary>
        /// 获取或设置事件端口号
        /// </summary>
        public int EventPort { get; set; }
        /// <summary>
        /// 获取或设置MAC地址
        /// </summary>
        public string MACAddress { get; set; }
        /// <summary>
        /// 获取或设置串口号
        /// </summary>
        public byte Commport { get; set; }
        /// <summary>
        /// 获取或设置地址
        /// </summary>
        public int Address { get; set; }
        /// <summary>
        /// 获取或设置是否用于考勤
        /// </summary>
        public bool ForAttendance { get; set; }
        #endregion
    }
}
