using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.DAL.IDAL;

namespace LJH.Attendance.BLL
{
    public class StaffBLL
    {
        #region 构造函数
        public StaffBLL(string repoUri)
        {
            _RepoUri = repoUri;
        }
        #endregion

        #region 私有变量
        private string _RepoUri;
        #endregion

        #region 公共方法
        public QueryResultList<Staff> GetItems(SearchCondition con)
        {
            return ProviderFactory.Create<IStaffProvider>(_RepoUri).GetItems(con);
        }

        public CommandResult Add(Staff info)
        {
            long? id = ProviderFactory.Create<IIntegerCreater>(_RepoUri).CreateID("Staff");
            if (id != null)
            {
                info.ID = (int)id.Value;
                return ProviderFactory.Create<IStaffProvider>(_RepoUri).Insert(info);
            }
            else
            {
                return new CommandResult(ResultCode.Fail, "创建ID失败");
            }
        }

        public CommandResult Update(Staff info)
        {
            Staff original = ProviderFactory.Create<IStaffProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IStaffProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Staff info)
        {
            return ProviderFactory.Create<IStaffProvider>(_RepoUri).Delete(info);
        }

        #region 人员照片相关
        public QueryResult<StaffPhoto> GetPhoto(int staffID)
        {
            return ProviderFactory.Create<IStaffPhotoProvider>(_RepoUri).GetByID(staffID);
        }

        public CommandResult SavePhoto(int staffID, string path)
        {
            StaffPhoto sp = new StaffPhoto(staffID, path);
            return ProviderFactory.Create<IStaffPhotoProvider>(_RepoUri).Insert(sp);
        }

        public CommandResult SavePhoto(int staffID, System.Drawing.Image photo)
        {
            StaffPhoto sp = new StaffPhoto();
            sp.StaffID = staffID;
            sp.Photo = photo;
            return ProviderFactory.Create<IStaffPhotoProvider>(_RepoUri).Insert(sp);
        }

        public CommandResult DeletePhoto(int staffID)
        {
            StaffPhoto sp = new StaffPhoto();
            sp.StaffID = staffID;
            return ProviderFactory.Create<IStaffPhotoProvider>(_RepoUri).Delete(sp);
        }
        #endregion

        #region 人员生物识别相关
        /// <summary>
        /// 获取某个人员的所有生物识别模板
        /// </summary>
        /// <param name="staffID"></param>
        /// <returns></returns>
        public QueryResultList<StaffBioTemplate> GetBioTemplates(int staffID)
        {
            StaffBioTemplateSearchCondition con = new StaffBioTemplateSearchCondition();
            con.StaffID = staffID;
            return ProviderFactory.Create<IStaffBioTemplateProvider>(_RepoUri).GetItems(con);
        }
        /// <summary>
        /// 保存生物识别模板，如果有系统中已经存在此模板，则替换
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public CommandResult SaveTemplate(StaffBioTemplate template)
        {
            StaffBioTemplate original = ProviderFactory.Create<IStaffBioTemplateProvider>(_RepoUri).GetByID(template.ID).QueryObject;
            if (original == null)
            {
                return ProviderFactory.Create<IStaffBioTemplateProvider>(_RepoUri).Insert(template);
            }
            else
            {
                return ProviderFactory.Create<IStaffBioTemplateProvider>(_RepoUri).Update(template, original);
            }
        }
        /// <summary>
        /// 删除生物识别模板
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public CommandResult DeleteTemplate(StaffBioTemplate template)
        {
            return ProviderFactory.Create<IStaffBioTemplateProvider>(_RepoUri).Delete(template);
        }
        #endregion
        #endregion
    }
}

