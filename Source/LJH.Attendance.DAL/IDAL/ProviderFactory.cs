using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.DAL.IDAL
{
    public class ProviderFactory
    {
        public static T Create<T>(string connStr) where T : class
        {
            T instance = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                if (asm != null)
                {
                    Type[] types = asm.GetTypes();
                    foreach (Type t in types)
                    {
                        if (t.IsClass && !t.IsAbstract)
                        {
                            foreach (Type inter in t.GetInterfaces())
                            {
                                if (inter == typeof(T))
                                {
                                    instance = Activator.CreateInstance(t, connStr) as T;
                                    return instance;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            Trace.Assert(instance != null, "在路径{0}中没有找到程序集LinqDataProvider.dll,系统即将退出!",Assembly.GetExecutingAssembly().Location);
            throw new Exception(string.Format("没有找到 {0} ,请确保 {1} 已经存在!", typeof(T).FullName, typeof(T).FullName));
        }
    }
}
