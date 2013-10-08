using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model.Result
{
    /// <summary>
    /// 查询结果
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Successful = 0,

        /// <summary>
        ///失败
        /// </summary>
        Fail = 2,

        /// <summary>
        /// 没有找到记录
        /// </summary>
        NoRecord = 3,

        /// <summary>
        /// 数据写入数据库时失败
        /// </summary>
        SaveDataError = 4,

        /// <summary>
        /// 连接服务器（数据库)失败
        /// </summary>
        CannotConnectServer = 5
    }
}
