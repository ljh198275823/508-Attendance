using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Device
{
    /// <summary>
    /// 表示读卡器生成工厂
    /// </summary>
    public class ReaderFactory
    {
        #region 工厂方法
        public static IReader Create(string model)
        {
            return null;
        }
        #endregion
    }
}
