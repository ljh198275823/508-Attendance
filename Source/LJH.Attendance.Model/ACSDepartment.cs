using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示门禁数据库的部门信息
    /// </summary>
    public class ACSDepartment
    {
        #region 构造函数
        public ACSDepartment()
        {
        }
        #endregion

        #region 公共属性
        public int ID { get; set; }

        public string Name{get;set;}
        #endregion
    }
}
