using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance .Model .Result ;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class ParameterBLL
    {
        #region 构造函数
        public ParameterBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        /// <summary>
        /// 获取参数，如果不存在，返回空
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetParameter<T>() where T : class ,new()
        {
            Parameter p = ProviderFactory.Create<IParameterProvider>(_RepoUri).GetByID(typeof(T).FullName).QueryObject;
            if (p == null || string.IsNullOrEmpty(p.Value)) return null;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (StringReader sr = new StringReader(p.Value))
                {
                    object obj = ser.Deserialize(sr);
                    if (obj != null) return obj as T;
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return null;
        }

        /// <summary>
        /// 获取参数，如果不存在，则创建一个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetOrDefaultParameter<T>() where T : class ,new()
        {
            T info = GetParameter<T>();
            if (info == null) info = new T();
            return info;
        }

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public CommandResult Save<T>(T item) where T : class ,new()
        {
            if (item != null)
            {
                try
                {
                    Parameter p = ProviderFactory.Create<IParameterProvider>(_RepoUri).GetByID(typeof(T).FullName).QueryObject;
                    string value = string.Empty;
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    using (StringWriter sw = new StringWriter())
                    {
                        ser.Serialize(sw, item);
                        StringBuilder sb = sw.GetStringBuilder();
                        if (sb != null) value = sb.ToString();
                    }
                    if (p == null)
                    {
                        p = new Parameter();
                        p.ID = typeof(T).FullName;
                        p.Value = value;
                        return ProviderFactory.Create<IParameterProvider>(_RepoUri).Insert(p);
                    }
                    else
                    {
                        Parameter p1 = new Parameter();
                        p1.ID = p.ID;
                        p1.Value = value;
                        return ProviderFactory.Create<IParameterProvider>(_RepoUri).Update(p1, p);
                    }
                }
                catch (Exception ex)
                {
                    LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                    return new CommandResult(ResultCode.Fail, ex.Message);
                }
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "没有参数");
            }
        }
        #endregion
    }
}
