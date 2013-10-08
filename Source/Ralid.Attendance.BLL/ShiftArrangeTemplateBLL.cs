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
    public class ShiftArrangeTemplateBLL
    {
        #region 构造函数
        public ShiftArrangeTemplateBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<ShiftArrangeTemplate> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IShiftArrangeTemplateProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(ShiftArrangeTemplate info)
        {
            return ProviderFactory.Create<IShiftArrangeTemplateProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(ShiftArrangeTemplate info)
        {
            ShiftArrangeTemplate original = ProviderFactory.Create<IShiftArrangeTemplateProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IShiftArrangeTemplateProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(ShiftArrangeTemplate info)
        {
            return ProviderFactory.Create<IShiftArrangeTemplateProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}