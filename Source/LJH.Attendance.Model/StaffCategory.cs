using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    public class StaffCategory
    {
        #region 构造函数
        public StaffCategory()
        {
        }
        #endregion

        #region 公共属性
        public string ID { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }
        #endregion
    }
}
