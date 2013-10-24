using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.DAL.IDAL
{
    /// <summary>
    /// 自增整数ID生成器,
    /// </summary>
    public interface IIntegerCreater
    {
        /// <summary>
        /// 生成ID
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        long? CreateID(string entity);
        /// <summary>
        /// 获取当前可用的ID,获取操作不会改变当前可用ID
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        long? GetCurID(string entity);
        /// <summary>
        /// 重置ID，即ID号从指定的整数开始自增
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="ID"></param>
        void ResetID(string entity, long id);
    }
}
