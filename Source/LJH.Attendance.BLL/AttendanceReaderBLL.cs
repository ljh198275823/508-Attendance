﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class AttendanceReaderBLL
    {
        #region 构造函数
        public AttendanceReaderBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<AttendanceReader> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IAttendanceReaderProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(AttendanceReader info)
        {
            return ProviderFactory.Create<IAttendanceReaderProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Delete(AttendanceReader info)
        {
            return ProviderFactory.Create<IAttendanceReaderProvider>(_RepoUri).Delete(info);
        }
        #endregion
    }
}