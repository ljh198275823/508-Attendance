using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Ralid.Attendance .Model ;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    internal class T_ShiftArrangeTemplate
    {
        #region 静态方法
        public static T_ShiftArrangeTemplate Create(ShiftArrangeTemplate item)
        {
            T_ShiftArrangeTemplate tst = new T_ShiftArrangeTemplate();
            tst.ID = item.ID;
            tst.Name = item.Name;
            tst.Options = item.Options;
            tst.Memo = item.Memo;
            if (item.Items != null && item.Items.Count > 0)
            {
                try
                {
                    using (StringWriter writer = new StringWriter())
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<TemplateItem>));
                        ser.Serialize(writer, item.Items);
                        if (writer.GetStringBuilder() != null)
                        {
                            tst.Value = writer.GetStringBuilder().ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                }
            }
            return tst;
        }

        public static ShiftArrangeTemplate Create(T_ShiftArrangeTemplate item)
        {
            ShiftArrangeTemplate st = new ShiftArrangeTemplate();
            st.ID = item.ID;
            st.Name = item.Name;
            st.Options = item.Options;
            st.Memo = item.Memo;
            if (!string.IsNullOrEmpty(item.Value))
            {
                try
                {
                    using (StringReader reader = new StringReader(item.Value))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<TemplateItem>));
                        st.Items = ser.Deserialize(reader) as List<TemplateItem>;
                    }
                }
                catch (Exception ex)
                {
                    Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                }
            }
            return st;
        }
        #endregion

        #region 构造函数
        public T_ShiftArrangeTemplate()
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 获取或设置模板名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 获取或设置选项
        /// </summary>
        public TemplateOptions Options { get; set; }
        /// <summary>
        /// 获取或设置值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 获取或设置备注
        /// </summary>
        public string Memo { get; set; }
        #endregion
    }
}
