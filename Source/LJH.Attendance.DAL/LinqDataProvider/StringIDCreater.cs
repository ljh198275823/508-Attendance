using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.LinqDataProvider
{
    public class StringIDCreater : IStringIDCreater
    {
        #region 构造函数
        public StringIDCreater(string connStr)
        {
            ConnectStr = connStr;
        }
        #endregion

        #region 私有变量
        private string ConnectStr;
        #endregion

        #region 实现 IAutoNumberCreater 接口
        /// <summary>
        /// 生成自动编号
        /// </summary>
        /// <param name="prefix">自动生成编号的前缀</param>
        /// <param name="numberFormat">自动生成的编号中自增序列号的长度</param>
        /// <param name="type">自动编号的类型</param>
        /// <returns></returns>
        public string CreateID(string prefix, string dateFormat, int serialLen, string type)
        {
            try
            {
                string head = string.Format("{0}{1}", prefix, DateTime.Now.ToString(dateFormat));
                DataContext dc = AttendanceDataContextFactory.Createattendance(ConnectStr);
                StringID num = dc.GetTable<StringID>().SingleOrDefault(item => item.Prefix == head && item.Entity == type);
                if (num == null)
                {
                    num = new StringID()
                    {
                        Prefix = head,
                        Serial = 1,
                        Entity = type
                    };
                    dc.GetTable<StringID>().InsertOnSubmit(num);
                }
                else
                {
                    num.Serial += 1;
                }
                dc.SubmitChanges();
                return num.Prefix + num.Serial.ToString("D" + serialLen);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return null;
        }

        /// <summary>
        /// 生成自动编号
        /// </summary>
        /// <param name="prefix">自动生成编号的前缀</param>
        /// <param name="numberFormat">自动生成的编号中自增序列号的长度</param>
        /// <param name="type">自动编号的类型</param>
        /// <returns></returns>
        public string CreateID(string prefix, int serialLen, string type)
        {
            try
            {
                DataContext dc = AttendanceDataContextFactory.Createattendance(ConnectStr);
                StringID num = dc.GetTable<StringID>().SingleOrDefault(item => item.Prefix == prefix && item.Entity == type);
                if (num == null)
                {
                    num = new StringID()
                    {
                        Prefix = prefix,
                        Serial = 1,
                        Entity = type
                    };
                    dc.GetTable<StringID>().InsertOnSubmit(num);
                }
                else
                {
                    num.Serial += 1;
                }
                dc.SubmitChanges();
                return num.Prefix + num.Serial.ToString("D" + serialLen);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return null;
        }
        #endregion
    }

    internal class StringID
    {
        public string Prefix { get; set; }

        public long Serial { get; set; }

        public string Entity { get; set; }
    }
}
