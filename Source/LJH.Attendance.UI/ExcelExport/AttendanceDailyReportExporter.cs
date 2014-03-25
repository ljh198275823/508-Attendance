using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using LJH.Attendance.Model;
using LJH.Attendance.Model.SearchCondition;
using LJH.Attendance.BLL;
using LJH.GeneralLibrary;

namespace LJH.Attendance.UI.ExcelExport
{
    public class AttendanceDailyReportExporter
    {
        #region 构造函数
        public AttendanceDailyReportExporter(string modalPath)
        {
            ReportModal = modalPath;
        }
        #endregion

        #region 私有变量
        private int _CurrentRow = 0;
        #endregion

        #region 私有方法
        private void FillRow(Staff staff, List<AttendanceResult> ars, Department dept, Worksheet sheet)
        {
            int row = _CurrentRow;
            Range r = sheet.get_Range(GetColName(1) + row, Type.Missing); //卡号
            r.Value = staff.CardID;
            r = sheet.get_Range(GetColName(2) + row, Type.Missing); //人员编号
            r.Value = staff.Certificate;
            r = sheet.get_Range(GetColName(3) + row, Type.Missing);//姓名
            r.Value = staff.Name;
            r = sheet.get_Range(GetColName(4) + row, Type.Missing);//电邮
            //r.Value = staff.Email;
            r = sheet.get_Range(GetColName(5) + row, Type.Missing);//所在单位
            r.Value = dept != null ? dept.Name : string.Empty;
            foreach (AttendanceResult ar in ars)
            {
                r = sheet.get_Range(GetColName(6) + row, Type.Missing);//日期
                r.Value = ar.ShiftDate;
                r = sheet.get_Range(GetColName(7) + row, Type.Missing);//应上班
                r.Value = ar.StartTime.ToString("HH:mm");
                r = sheet.get_Range(GetColName(8) + row, Type.Missing);//实上班
                r.Value = ar.OnDutyTime != null ? ar.OnDutyTime.Value.ToString("HH:mm") : "--";
                if (ar.OnDutyTime == null || ar.Result == AttendanceResultCode.Late || ar.Result == AttendanceResultCode.LateEarly)
                {
                    r.Font.Color = System.Drawing.Color.Red;
                    r.Font.Bold = 1;
                    sheet.get_Range(GetColName(6) + row, GetColName(13) + row).Interior.Color = System.Drawing.Color.Yellow;
                }
                r = sheet.get_Range(GetColName(9) + row, Type.Missing);//应下班
                r.Value = ar.EndTime.ToString("HH:mm");
                r = sheet.get_Range(GetColName(10) + row, Type.Missing);//实下班
                r.Value = ar.OffDutyTime != null ? ar.OffDutyTime.Value.ToString("HH:mm") : "--";
                if (ar.OffDutyTime == null || ar.Result == AttendanceResultCode.LeaveEarly || ar.Result == AttendanceResultCode.LateEarly)
                {
                    r.Font.Color = System.Drawing.Color.Red;
                    r.Font.Bold = 1;
                    sheet.get_Range(GetColName(6) + row, GetColName(13) + row).Interior.Color = System.Drawing.Color.Yellow;
                }
                r = sheet.get_Range(GetColName(11) + row, Type.Missing);//考勤结果
                r.Value = ar.ResultDescr;
                r = sheet.get_Range(GetColName(12) + row, Type.Missing);//应出勤(h)
                r.Value = (ar.ShiftTime / 60).Trim();
                r = sheet.get_Range(GetColName(13) + row, Type.Missing);//实出勤(h)
                r.Value = (ar.Present / 60).Trim();
                row++;
            }
            sheet.get_Range(GetColName(1) + _CurrentRow, GetColName(1) + (row - 1)).Merge(Type.Missing);
            sheet.get_Range(GetColName(2) + _CurrentRow, GetColName(2) + (row - 1)).Merge(Type.Missing);
            sheet.get_Range(GetColName(3) + _CurrentRow, GetColName(3) + (row - 1)).Merge(Type.Missing);
            sheet.get_Range(GetColName(4) + _CurrentRow, GetColName(4) + (row - 1)).Merge(Type.Missing);
            sheet.get_Range(GetColName(5) + _CurrentRow, GetColName(5) + (row - 1)).Merge(Type.Missing);
            _CurrentRow = row;
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

                if (users != null && users.Count > 0)
                {
                    List<Department> depts = (new DepartmentBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
                    List<int> staff = users.Select(item => item.ID).ToList();
                    StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
                    con.Staff = staff;
                    DateTime dt = new DateTime(year, month, 1);
                    con.ShiftDate = new DatetimeRange(dt, dt.AddMonths(1).AddSeconds(-1));
                    List<AttendanceResult> arranges = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con).QueryObjects;
                    _CurrentRow = 2;
                    foreach (Staff s in users)
                    {
                        List<AttendanceResult> rets = (from it in arranges where it.StaffID == s.ID orderby it.StartTime ascending select it).ToList();
                        if (rets != null && rets.Count > 0)
                        {
                            Department dept = depts.SingleOrDefault(it => it.ID == s.DepartmentID);
                            FillRow(s, rets, dept, sheet);
                        }
                    }
                    sheet.get_Range("A1", GetColName(13) + (_CurrentRow - 1)).Borders.LineStyle = XlLineStyle.xlContinuous;
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
        #endregion
    }
}
