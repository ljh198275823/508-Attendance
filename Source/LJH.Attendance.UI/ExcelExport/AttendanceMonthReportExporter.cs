using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using LJH.Attendance .Model ;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance .BLL ;
using LJH.GeneralLibrary;

namespace LJH.Attendance.UI.ExcelExport
{
    /// <summary>
    /// 表示考勤月统计报表导出类
    /// </summary>
    public class AttendanceMonthReportExporter
    {
        public AttendanceMonthReportExporter(string modalPath)
        {
            ReportModal = modalPath;
        }

        #region 公共属性
        /// <summary>
        /// 获取或设置EXCEL模板的路径
        /// </summary>
        public string ReportModal { get; set; }
        #endregion

        #region 公共方法
        /// <summary>
        /// 导出相关人员在某一段时间的考勤报表
        /// </summary>
        /// <param name="staff"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public void Export(List<Staff> users, int year, int month, string path)
        {
            Workbook book = null;
            try
            {
                Application app = new Application();
                book = app.Workbooks.Add(ReportModal); //打开模板
                Worksheet sheet = book.ActiveSheet as Worksheet;
                Exportweek(year, month, sheet);

                if (users != null && users.Count > 0)
                {
                    List<Department> depts = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(null).QueryObjects;
                    List<int> staff = users.Select(item => item.ID).ToList();
                    StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
                    con.Staff = staff;
                    DateTime dt = new DateTime(year, month, 1);
                    con.ShiftDate = new DatetimeRange(dt, dt.AddMonths(1).AddSeconds(-1));
                    List<AttendanceResult> arranges = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectUri)).GetItems(con).QueryObjects;
                    int row = 1;
                    foreach (Staff s in users)
                    {
                        List<AttendanceResult> rets = (from it in arranges where it.StaffID == s.ID orderby it.StartTime ascending select it).ToList();
                        if (rets != null && rets.Count > 0)
                        {
                            AddStaff(s, rets, depts, sheet, row);
                            row++;
                        }
                    }
                    sheet.get_Range("A1", GetColName(49) + (2 + (row - 1) * 3)).Borders.LineStyle = XlLineStyle.xlContinuous;
                }
                book.SaveAs(path, XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            finally
            {
                book.Close(false, Type.Missing, Type.Missing);
            }
        }

        private void Exportweek(int year, int month, Worksheet sheet)
        {
            DateTime dtBegin = new DateTime(year, month, 1);
            for (int i = 0; i < 31; i++)
            {
                DateTime dt = dtBegin.AddDays(i);
                string week = string.Empty;
                if (dt.DayOfWeek == DayOfWeek.Sunday) week = "日";
                else if (dt.DayOfWeek == DayOfWeek.Monday) week = "一";
                else if (dt.DayOfWeek == DayOfWeek.Tuesday) week = "二";
                else if (dt.DayOfWeek == DayOfWeek.Wednesday) week = "三";
                else if (dt.DayOfWeek == DayOfWeek.Thursday) week = "四";
                else if (dt.DayOfWeek == DayOfWeek.Friday) week = "五";
                else if (dt.DayOfWeek == DayOfWeek.Saturday) week = "六";
                Range r = sheet.get_Range(GetColName(10 + i) + 2, Type.Missing);
                r.Value = week;
                if (week == "日")
                {
                    //sheet.get_Range (GetColName(10 + i)+65535)
                }
            }
        }

        private void AddStaff(Staff staff, List<AttendanceResult> items, List<Department> depts, Worksheet sheet, int row)
        {
            int myRow = 3 + (row - 1) * 3; //从第三行开始输入数据,每个人占三行
            Range r = sheet.get_Range(GetColName(1) + myRow, Type.Missing); //序号
            r.Value = row;
            Department dept = depts.SingleOrDefault(it => it.ID == staff.DepartmentID);
            Department root = null;
            if (dept != null) root = GetRoot(depts, dept);
            r = sheet.get_Range(GetColName(2) + myRow, Type.Missing); //中心
            r.Value = root != null ? root.Name : string.Empty;
            r = sheet.get_Range(GetColName(3) + myRow, Type.Missing); //部门
            r.Value = dept != null ? dept.Name : string.Empty;
            r = sheet.get_Range(GetColName(5) + myRow, Type.Missing);  //职位
            r.Value = staff.UserPosition;
            r = sheet.get_Range(GetColName(6) + myRow, Type.Missing);  //姓名
            r.Value = staff.Name;
            r = sheet.get_Range(GetColName(9) + myRow, Type.Missing);  //
            r.Value = "上午";
            r = sheet.get_Range(GetColName(9) + (myRow + 1), Type.Missing);  //
            r.Value = "下午";
            r = sheet.get_Range(GetColName(9) + (myRow + 2), Type.Missing);  //
            r.Value = "加班";
            for (int i = 1; i <= 8; i++)
            {
                sheet.get_Range(GetColName(i) + myRow, GetColName(i) + (myRow + 2)).Merge(Type.Missing);
            }
            for (int i = 1; i <= 31; i++)
            {
                List<AttendanceResult> rets = (from item in items where item.ShiftDate.Day == i && !string.IsNullOrEmpty(item.ShiftID) orderby item.StartTime ascending select item).ToList();
                if (rets != null && rets.Count > 0)
                {
                    if (rets.Count >= 1)
                    {
                        r = sheet.get_Range(GetColName(9 + i) + (myRow + 0), Type.Missing);
                        r.Value = (rets[0].Present / 60).Trim();
                    }
                    if (rets.Count >= 2)
                    {
                        r = sheet.get_Range(GetColName(9 + i) + (myRow + 1), Type.Missing);
                        r.Value = (rets[1].Present / 60).Trim(); ;
                    }
                }
                decimal ot = (from item in items where item.ShiftDate.Day == i && string.IsNullOrEmpty(item.ShiftID) && !string.IsNullOrEmpty(item.Category) select item).Sum(item => item.Present);
                if (ot > 0)
                {
                    r = sheet.get_Range(GetColName(9 + i) + (myRow + 2), Type.Missing);
                    r.Value = (ot / 60).Trim();
                }
            }
            for (int i = 41; i <= 49; i++)
            {
                sheet.get_Range(GetColName(i) + myRow, GetColName(i) + (myRow + 2)).Merge(Type.Missing);
            }
            sheet.get_Range(GetColName(41) + myRow).Value = string.Format("=SUM(J{0}:AN{1})", myRow + 2, myRow + 2);
            sheet.get_Range(GetColName(42) + myRow).Value = string.Format("=COUNTIF(J{0}:AN{1},\"△\")*4", myRow, myRow + 1);
            sheet.get_Range(GetColName(45) + myRow).Value = string.Format("=COUNTIF(J{0}:AN{1},\"休\")*4", myRow, myRow + 1);
            sheet.get_Range(GetColName(46) + myRow).Value = string.Format("=SUM(J{0}:AN{1})", myRow, myRow + 1);
            sheet.get_Range(GetColName(48) + myRow).Value = string.Format("=AS{0}+AT{1}", myRow, myRow); //总小时数
        }

        private Department GetRoot(List<Department> depts, Department dept)
        {
            Department d = dept;
            while (!string.IsNullOrEmpty(d.ParentID))
            {
                Department temp = depts.SingleOrDefault(it => it.ID == d.ParentID);
                if (temp == null) break;
                d = temp;
            }
            return d;
        }

        private string GetColName(int col)
        {
            string temp = string.Empty;
            int t1 = col / 27;
            if (t1 == 1) temp = "A";
            if (t1 == 2) temp = "B";
            if (t1 == 3) temp = "C";
            int t2 = col - t1 * 26;
            char ch = (char)((int)'A' + t2 - 1);
            temp = temp + ch.ToString();
            return temp;
        }

        private void AddBorder(Range r)
        {
            r.Borders.LineStyle = XlLineStyle.xlContinuous;
        }
        #endregion
    }
}
