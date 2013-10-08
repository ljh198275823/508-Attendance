using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class ShiftTemplateBLL
    {
        #region 构造函数
        public ShiftTemplateBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<ShiftTemplate> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IShiftTemplateProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(ShiftTemplate info)
        {
            return ProviderFactory.Create<IShiftTemplateProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(ShiftTemplate info)
        {
            ShiftTemplate original = ProviderFactory.Create<IShiftTemplateProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IShiftTemplateProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(ShiftTemplate info)
        {
            return ProviderFactory.Create<IShiftTemplateProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}