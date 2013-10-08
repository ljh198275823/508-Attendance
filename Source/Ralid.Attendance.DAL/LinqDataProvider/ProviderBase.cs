using System;
using System.Linq;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using Ralid.Attendance.DAL.IDAL;
using Ralid.Attendance.Model;
using Ralid.Attendance .Model.Result;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.GeneralLibrary.ExceptionHandling;

namespace Ralid.Attendance.DAL.LinqDataProvider
{
    public abstract class ProviderBase<TInfo, TID> : IProvider<TInfo, TID> where TInfo : class, new()
    {
        #region 构造函数
        public ProviderBase(string connectStr)
        {
            this.ConnectStr = connectStr;
        }

        public ProviderBase()
        {
        }
        #endregion

        #region 变量
        protected readonly string successMsg = "ok";

        public string ConnectStr { get; set; }
        #endregion

        #region IProvider <TInfo> 成员

        public QueryResult<TInfo> GetByID(TID id)
        {
            QueryResult<TInfo> result = null;
            try
            {
                AttendanceDataContext attendance = AttendanceDataContextFactory.Createattendance(ConnectStr);
                TInfo info = GetingItemByID(id, attendance);
                if (info != null)
                {
                    result = new QueryResult<TInfo>(ResultCode.Successful, successMsg, info);
                }
                else
                {
                    result = new QueryResult<TInfo>(ResultCode.Fail, string.Empty, info);
                }
            }
            catch (SqlException ex)
            {
                result = new QueryResult<TInfo>(ResultCodeResolver.GetFromSqlExceptionNumber(ex.Number), ex.Message, null);
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "GetByID()");
            }
            catch (Exception ex)
            {
                result = new QueryResult<TInfo>(ResultCode.Fail, ex.Message, null);
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "GetByID()");
            }
            return result;
        }

        public QueryResultList<TInfo> GetItems(SearchCondition search)
        {
            QueryResultList<TInfo> result;
            try
            {
                AttendanceDataContext attendance = AttendanceDataContextFactory.Createattendance(ConnectStr);
                List<TInfo> infoes;
                infoes = GetingItems(attendance, search);
                result = new QueryResultList<TInfo>(ResultCode.Successful, successMsg, infoes);
            }
            catch (SqlException ex)
            {
                result = new QueryResultList<TInfo>(ResultCodeResolver.GetFromSqlExceptionNumber(ex.Number), ex.Message, new List<TInfo>());
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "GetItems()");
            }
            catch (Exception ex)
            {
                result = new QueryResultList<TInfo>(ResultCode.Fail, ex.Message, new List<TInfo>());
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "GetItems()");
            }
            return result;
        }

        public CommandResult Insert(TInfo info)
        {
            CommandResult result;
            try
            {
                AttendanceDataContext attendance = AttendanceDataContextFactory.Createattendance(ConnectStr);
                InsertingItem(info, attendance);
                attendance.SubmitChanges();
                result = new CommandResult(ResultCode.Successful, successMsg);
            }
            catch (SqlException ex)
            {
                result = new CommandResult(ResultCodeResolver.GetFromSqlExceptionNumber(ex.Number), ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "Insert()");
            }
            catch (Exception ex)
            {
                result = new CommandResult(ResultCode.Fail, ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().Name + "." + "Insert()");
            }
            return result;
        }

        public CommandResult Update(TInfo newVal, TInfo original)
        {
            CommandResult result;
            try
            {
                AttendanceDataContext attendance = AttendanceDataContextFactory.Createattendance(ConnectStr);
                UpdatingItem(newVal, original, attendance);
                attendance.SubmitChanges();
                result = new CommandResult(ResultCode.Successful, successMsg);
            }
            catch (SqlException ex)
            {
                result = new CommandResult(ResultCodeResolver.GetFromSqlExceptionNumber(ex.Number), ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().FullName + "." + "Update()");
            }
            catch (Exception ex)
            {
                result = new CommandResult(ResultCode.Fail, ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().FullName + "." + "Update()");
            }
            return result;
        }

        public CommandResult Delete(TInfo info)
        {
            CommandResult result;
            try
            {
                AttendanceDataContext attendance = AttendanceDataContextFactory.Createattendance(ConnectStr);
                DeletingItem(info, attendance);
                attendance.SubmitChanges();
                result = new CommandResult(ResultCode.Successful, successMsg);
            }
            catch (SqlException ex)
            {
                result = new CommandResult(ResultCodeResolver.GetFromSqlExceptionNumber(ex.Number), ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().FullName + "." + "Delete()");
            }
            catch (Exception ex)
            {
                result = new CommandResult(ResultCode.Fail, ex.Message);
                ExceptionPolicy.HandleException(ex, this.GetType().FullName + "." + "Delete()");
            }
            return result;
        }

        public void Insert(TInfo info, IUnitWork unitWork)
        {
            if (unitWork == null)
            {
                throw new NullReferenceException("参数unitWork为空!");
            }
            UnitWork trans = unitWork as UnitWork;
            if (trans != null)
            {
                AttendanceDataContext attendance = trans.attendance;
                InsertingItem(info, attendance);
            }
            else
            {
                throw new InvalidCastException("参数unitWork不能转换成类型Ralid.LinqDataProvider.UnitWork," +
                    "请检查参数是否是一个Ralid.LinqDataProvider.UnitWork实例!");
            }
        }

        public void Update(TInfo newVal, TInfo originalVal, IUnitWork unitWork)
        {
            if (unitWork == null)
            {
                throw new NullReferenceException("参数unitWork为空!");
            }
            UnitWork trans = unitWork as UnitWork;
            if (trans != null)
            {
                AttendanceDataContext attendance = trans.attendance;
                UpdatingItem(newVal, originalVal, attendance);
            }
            else
            {
                throw new InvalidCastException("参数unitWork不能转换成类型Ralid.LinqDataProvider.UnitWork," +
                    "请检查参数是否是一个Ralid.LinqDataProvider.UnitWork实例!");
            }
        }

        public void Delete(TInfo info, IUnitWork unitWork)
        {
            if (unitWork == null)
            {
                throw new NullReferenceException("参数unitWork为空!");
            }
            UnitWork trans = unitWork as UnitWork;
            if (trans != null)
            {
                AttendanceDataContext attendance = trans.attendance;
                DeletingItem(info, attendance);
            }
            else
            {
                throw new InvalidCastException("参数unitWork不能转换成类型Ralid.LinqDataProvider.UnitWork," +
                    "请检查参数是否是一个Ralid.LinqDataProvider.UnitWork实例!");
            }
        }
        #endregion

        #region 模板方法
        protected virtual TInfo GetingItemByID(TID id, AttendanceDataContext attendance)
        {
            //每一个子类都要重写这个方法
            throw new Exception("子类没有重写GetingItemByID方法!");
        }
        protected virtual List<TInfo> GetingItems(AttendanceDataContext attendance, SearchCondition search)
        {
            IQueryable<TInfo> ret = attendance.GetTable<TInfo>();
            return ret.ToList();
        }
        protected virtual void InsertingItem(TInfo info, AttendanceDataContext attendance)
        {
            attendance.GetTable<TInfo>().InsertOnSubmit(info);
        }
        protected virtual void UpdatingItem(TInfo newVal, TInfo original, AttendanceDataContext attendance)
        {
            //所有实体都可以用这个方法来更新数据
            attendance.GetTable<TInfo>().Attach(newVal, original);
        }
        protected virtual void DeletingItem(TInfo info, AttendanceDataContext attendance)
        {
            //如果删除实体时要删除其关联数据,就得重写这个方法
            attendance.GetTable<TInfo>().Attach(info);
            attendance.GetTable<TInfo>().DeleteOnSubmit(info);
        }
        #endregion
    }
}
