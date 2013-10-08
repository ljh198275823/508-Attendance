using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance;
using Ralid.Attendance.Model.SearchCondition;
using Ralid.Attendance.Model.Result;

namespace Ralid.Attendance.DAL.IDAL
{
    public interface IProvider<TInfo, TID>
    {
        /// <summary>
        /// 通过ID获取对像
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        QueryResult<TInfo> GetByID(TID id);
        /// <summary>
        /// 通过查询条件获取对象
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        QueryResultList<TInfo> GetItems(SearchCondition search);
        /// <summary>
        /// 插入对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        CommandResult Insert(TInfo t);
        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="newVal"></param>
        /// <param name="originalVal"></param>
        /// <returns></returns>
        CommandResult Update(TInfo newVal, TInfo originalVal);
        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        CommandResult Delete(TInfo t);
        /// <summary>
        /// 插入对象,这个操作属于一个单元操作的一部分
        /// </summary>
        /// <param name="t"></param>
        /// <param name="unitWork"></param>
        /// <returns></returns>
        void Insert(TInfo t, IUnitWork unitWork);
        /// <summary>
        /// 更新对象,这个操作属于一个单元操作的一部分
        /// </summary>
        /// <param name="t"></param>
        /// <param name="unitWork"></param>
        /// <returns></returns>
        void Update(TInfo newVal, TInfo originalVal, IUnitWork unitWork);
        /// <summary>
        /// 删除对象,这个操作属于一个单元操作的一部分
        /// </summary>
        /// <param name="t"></param>
        /// <param name="unitWork"></param>
        /// <returns></returns>
        void Delete(TInfo t, IUnitWork unitWork);
    }
}
