using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示指纹机验证方式
    /// </summary>
    public enum VerifyCode
    {
        /// <summary>
        /// 未指定
        /// </summary>
        None = 0,
        /// <summary>
        /// 卡加指纹
        /// </summary>
        PIN_AND_FP = 8,
        /// <summary>
        /// 指纹加密码
        /// </summary>
        FP_AND_PW = 9,
        /// <summary>
        /// 指纹加卡加密码
        /// </summary>
        FP_AND_PW_AND_PIN = 13
    }
}
