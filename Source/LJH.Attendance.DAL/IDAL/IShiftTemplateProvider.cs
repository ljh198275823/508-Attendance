using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LJH.Attendance.DAL.IDAL
{
    public interface IShiftTemplateProvider : IProvider<LJH.Attendance.Model.ShiftTemplate, Guid>
    {
    }
}