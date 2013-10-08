﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model;
using Ralid.Attendance.Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.DAL.IDAL;

namespace Ralid.Attendance.BLL
{
    public class ACSDepartmentBLL
    {
        #region 构造函数
        public ACSDepartmentBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Department> GetItems(SearchCondition con)
        {
            List<Department> depts = new List<Department>();
            QueryResultList<ACSDepartment> ret = ProviderFactory.Create<IACSDepartmentProvider>(_RepoUri).GetItems(con);
            if (ret.Result == ResultCode.Successful)
            {
                foreach (ACSDepartment item in ret.QueryObjects)
                {
                    Department dept = new Department();
                    dept.ID = item.ID.ToString("D3");
                    dept.Name = item.Name;
                    dept.ParentID = null;
                    depts.Add(dept);
                }
            }
            return new QueryResultList<Department>(ret.Result, ret.Message, depts);
        }
        #endregion
    }
}
