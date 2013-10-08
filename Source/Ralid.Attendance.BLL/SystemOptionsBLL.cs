using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection ;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class SystemOptionsBLL
    {
        #region 构造函数
        public SystemOptionsBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        /// <summary>
        /// 从数据库中获取系统选项，如果失败返回一个默认值的对象
        /// </summary>
        /// <returns></returns>
        public SystemOptions Get()
        {
            SystemOptions options = new SystemOptions();
            ISysparameterProvider provider = ProviderFactory.Create<ISysparameterProvider>(_RepoUri);
            Sysparameter sp = provider.GetByID("UsingACSDept").QueryObject;
            if (sp != null)
            {
                options.UsingACSDept = sp.Value == "0" ? false : true;
            }
            return options;
        }

        public CommandResult Save(SystemOptions options)
        {
            ISysparameterProvider provider = ProviderFactory.Create<ISysparameterProvider>(_RepoUri);
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            Sysparameter sp = provider.GetByID("UsingACSDept").QueryObject;
            if (sp != null)
            {
                Sysparameter sp1 = sp.Clone();
                sp.Value = options.UsingACSDept ? "1" : "0";
                provider.Update(sp, sp1, unitWork);
            }
            else
            {
                sp = new Sysparameter()
                {
                    ID = "UsingACSDept",
                    Value = options.UsingACSDept ? "1" : "0"
                };
                provider.Insert(sp, unitWork);
            }
            return unitWork.Commit();
        }
        #endregion
    }
}
