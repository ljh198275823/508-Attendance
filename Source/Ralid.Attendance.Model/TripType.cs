﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model
{
    public class TripType
    {
        #region 构造函数
        public TripType()
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
