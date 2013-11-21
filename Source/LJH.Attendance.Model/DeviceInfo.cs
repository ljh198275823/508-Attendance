﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁刷卡器
    /// </summary>
    public class DeviceInfo
    {
        #region 构造函数
        public DeviceInfo()
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
        /// 获取或设置机器序列号
        /// </summary>
        public string Serial { get; set; }
        /// <summary>
        /// 获取或设置设备类型 0表示中控指纹门禁机 1表示IPC系统系列
        /// </summary>
        public DeviceType DeviceType { get; set; }
        /// <summary>
        /// 获取或设置通讯方式 目前支持三种方式 0:TCP/IP 1:RS232/485 2:USB
        /// </summary>
        public CommunicationType Communication { get; set; }
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
        public int? ControlPort { get; set; }
        /// <summary>
        /// 获取或设置事件端口号
        /// </summary>
        public int? EventPort { get; set; }
        /// <summary>
        /// 获取或设置MAC地址
        /// </summary>
        public string MACAddress { get; set; }
        /// <summary>
        /// 获取或设置串口号
        /// </summary>
        public int? Commport { get; set; }
        /// <summary>
        /// 获取或设置波特率
        /// </summary>
        public int? Baud { get; set; }
        /// <summary>
        /// 获取或设置地址
        /// </summary>
        public int? Address { get; set; }
        /// <summary>
        /// 获取或设置是否用于考勤
        /// </summary>
        public bool ForAttendance { get; set; }
        /// <summary>
        /// 获取或设置设备组ID
        /// </summary>
        public string GroupID { get; set; }
        #endregion
    }
}