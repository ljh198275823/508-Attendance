using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LJH.Attendance .Model ;
using LJH.Attendance .Model .Result ;
using LJH.Attendance .Model .SearchCondition ;
using LJH.Attendance .DAL .IDAL ;

namespace LJH.Attendance.BLL
{
    public class DepartmentBLL
    {
        #region 构造函数
        public DepartmentBLL(string repoUri)
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
            return ProviderFactory.Create<IDepartmentProvider>(_RepoUri).GetItems(con);
        }

        public string CreateADeptID(Department parent)
        {
            List<Department> depts = ProviderFactory.Create<IDepartmentProvider>(_RepoUri).GetItems(null).QueryObjects;
            List<Department> children = null;
            if (parent == null)
            {
                children = depts.Where(item => string.IsNullOrEmpty(item.ParentID)).ToList();
            }
            else
            {
                children = depts.Where(item => item.ParentID == parent.ID).ToList();
            }
            string parentID = parent == null ? string.Empty : parent.ID;
            for (int i = 1; i < 100; i++)
            {
                string childID = parentID + i.ToString("D2");
                if (!children.Exists(item => item.ID == childID))
                {
                    return childID;
                }
            }
            return string.Empty;
        }

        public CommandResult Add(Department info)
        {
            return ProviderFactory.Create<IDepartmentProvider>(_RepoUri).Insert(info);
        }

        public CommandResult Update(Department info)
        {
            Department original = ProviderFactory.Create<IDepartmentProvider>(_RepoUri).GetByID(info.ID).QueryObject;
            if (original != null)
            {
                return ProviderFactory.Create<IDepartmentProvider>(_RepoUri).Update(info, original);
            }
            else
            {
                return new CommandResult(ResultCode.NoRecord, ResultCodeDecription.GetDescription(ResultCode.NoRecord));
            }
        }

        public CommandResult Delete(Department info)
        {
            List<Department> depts = ProviderFactory.Create<IDepartmentProvider>(_RepoUri).GetItems(null).QueryObjects;
            IUnitWork unitWork = ProviderFactory.Create<IUnitWork>(_RepoUri);
            foreach (Department dept in depts.Where(item => item.ID.IndexOf(info.ID, 0) == 0))
            {
                ProviderFactory.Create<IDepartmentProvider>(_RepoUri).Delete(dept, unitWork);
            }
            List<Staff> staffs = ProviderFactory.Create<IStaffProvider>(_RepoUri).GetItems(null).QueryObjects;
            foreach (Staff staff in staffs)
            {
                if (staff.DepartmentID == info.ID)
                {
                    Staff staff1 = staff.Clone();
                    staff.DepartmentID = null;
                    ProviderFactory.Create<IStaffProvider>(_RepoUri).Update(staff, staff1, unitWork);
                }
            }
            return unitWork.Commit();
        }
        #endregion
    }
}