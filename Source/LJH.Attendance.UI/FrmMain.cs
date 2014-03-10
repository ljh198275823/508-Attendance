using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LJH.GeneralLibrary.SoftDog;
using LJH.Attendance.BLL;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.Model.SearchCondition;
using LJH.GeneralLibrary.SQLHelper;

namespace LJH.Attendance.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 私有变量
        private List<Form> _openedForms = new List<Form>();
        private bool _HasGenerateResult = false; //是否已经自动生成了考勤结果,用于自动生成考勤结果
        #endregion

        #region 私有方法
        private void ReadSoftDog()
        {
            SoftDogReader reader = new SoftDogReader();
            SoftDogInfo info = null;
            bool ret = true;
            try
            {
                info = reader.ReadDog();
                if (info == null)
                {
                    MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmMain_SoftDogError, LJH.Attendance.UI.Properties.Resources.Form_Alert);
                    ret = false;
                }
                else if ((info.SoftwareList & SoftwareType.TYPE_TA) == 0)  //没有写考勤软件权限
                {
                    MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmMain_SoftDogNoRights, LJH.Attendance.UI.Properties.Resources.Form_Alert);
                    ret = false;
                }
                else if (info.ExpiredDate < DateTime.Today && info.ExpiredDate.AddDays(15) >= DateTime.Today) //已经过期
                {
                    DateTime expire = info.ExpiredDate.AddDays(15);
                    TimeSpan ts = new TimeSpan(expire.Ticks - DateTime.Today.Ticks);
                    MessageBox.Show(string.Format(LJH.Attendance.UI.Properties.Resources.FrmMain_SoftDogExpiredAlert, (int)(ts.TotalDays + 1)), LJH.Attendance.UI.Properties.Resources.Form_Alert);
                }
                else if (info.ExpiredDate.AddDays(15) < DateTime.Today)
                {
                    MessageBox.Show(LJH.Attendance.UI.Properties.Resources.FrmMain_SoftDogExpired, LJH.Attendance.UI.Properties.Resources.Form_Alert);
                    ret = false;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                ret = false;
            }

            if (!ret)
            {
                System.Environment.Exit(0);
            }
        }

        private void Authenticate()
        {
            while (true)
            {
                FrmLogin login = new FrmLogin();
                DialogResult result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    break;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                    break;
                }
            }
        }

        private void ShowOperatorRights()
        {
            Operator opt = Operator.CurrentOperator;
            if (opt == null) return;
            //基本资料
            mnu_Departments.Enabled = opt.Permit(Permission.ReadDepartment) || opt.Permit(Permission.EditDepartment);
            btnDepartment.Enabled = opt.Permit(Permission.ReadDepartment) || opt.Permit(Permission.EditDepartment);
            mnu_Staff.Enabled = opt.Permit(Permission.ReadStaff) || opt.Permit(Permission.EditStaff);
            btnStaff.Enabled = opt.Permit(Permission.ReadStaff) || opt.Permit(Permission.EditStaff);
            mnu_OTType.Enabled = opt.Permit(Permission.ReadOTType) || opt.Permit(Permission.EditOTType);
            mnu_VacationType.Enabled = opt.Permit(Permission.ReadVacationType) || opt.Permit(Permission.EditVacationType);
            mnu_TripType.Enabled = opt.Permit(Permission.ReadTripType) || opt.Permit(Permission.EditTripType);
            mnu_TASheet.Enabled = opt.Permit(Permission.ReadTASheet) || opt.Permit(Permission.EditTASheet);
            btnTASheet.Enabled = opt.Permit(Permission.ReadTASheet) || opt.Permit(Permission.EditTASheet);
            mnu_Holiday.Enabled = opt.Permit(Permission.ReadHoliday) || opt.Permit(Permission.EditHoliday);
            btnHoliday.Enabled = opt.Permit(Permission.ReadHoliday) || opt.Permit(Permission.EditHoliday);
            mnu_AttendanceDevice.Enabled = opt.Permit(Permission.SelectAttendanceReader);
            btnAttendanceDevice.Enabled = opt.Permit(Permission.SelectAttendanceReader);
            mnu_Options.Enabled = opt.Permit(Permission.ReadOptions) || opt.Permit(Permission.EditOptions);
            mnu_StaffCategory.Enabled = opt.Permit(Permission.ReadStaffCategory) || opt.Permit(Permission.EditStaffCategory);
            mnu_AttendanceDevice.Enabled = opt.Permit(Permission.ReadAttendanceDevice) || opt.Permit(Permission.EditAttendanceDevice);
            btnAttendanceDevice.Enabled = opt.Permit(Permission.ReadAttendanceDevice) || opt.Permit(Permission.EditAttendanceDevice);

            //考勤管理
            mnu_Shifts.Enabled = opt.Permit(Permission.ReadShift) || opt.Permit(Permission.EditShift);
            btnShift.Enabled = opt.Permit(Permission.ReadShift) || opt.Permit(Permission.EditShift);
            mnu_ShiftArrange.Enabled = opt.Permit(Permission.ReadShiftArrange) || opt.Permit(Permission.ShiftArrange);
            btnShiftArrange.Enabled = opt.Permit(Permission.ReadShiftArrange) || opt.Permit(Permission.ShiftArrange);
            mnu_ManualLog.Enabled = opt.Permit(Permission.ManualLog);
            btnManualLog.Enabled = opt.Permit(Permission.ManualLog);
            mnu_AttendanceAnalyst.Enabled = opt.Permit(Permission.AttendanceAnalyst);
            btnAttendanceAnalyst.Enabled = opt.Permit(Permission.AttendanceAnalyst);
            mnu_ShiftResultMaster.Enabled = opt.Permit(Permission.ReadShiftResult) || opt.Permit(Permission.EditShiftResult);
            //安全管理
            mnu_Operator.Enabled = opt.Permit(Permission.ReadOperaotor) || opt.Permit(Permission.EditOperator);
            mnu_Role.Enabled = opt.Permit(Permission.ReadRole) || opt.Permit(Permission.EditRole);

            //报表
            mnu_ShiftResultStatistics.Enabled = opt.Permit(Permission.ShiftResultStatistics);
            btnShiftResultStatistics.Enabled = opt.Permit(Permission.ShiftResultStatistics);
            mnu_ResultMonthReport.Enabled = opt.Permit(Permission.ShiftResultStatistics2);
            btnShiftResultStatistics2.Enabled = opt.Permit(Permission.ShiftResultStatistics2);
            mnu_ResultDayReport.Enabled = opt.Permit(Permission.ResultDetail);
            btnResultDetail.Enabled = opt.Permit(Permission.ResultDetail);
            mnu_AttendanceLogReport.Enabled = opt.Permit(Permission.AttendanceLogReport);
            btnAttendanceLog.Enabled = opt.Permit(Permission.AttendanceLogReport);
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 显示窗口的单个实例，如果之前已经打开过，则只是激活打开过的窗体
        /// </summary>
        /// <param name="formType">要打开的窗体类型</param>
        /// <param name="mainPanel">是否在主面板中打开,否则在从面板中打开</param>
        public Form ShowSingleForm(Type formType)
        {
            Form instance = null;
            foreach (Form frm in _openedForms)
            {
                if (frm.GetType() == formType)
                {
                    instance = frm;
                    ucFormViewMain.ActiveForm(frm);
                    break;
                }
            }
            if (instance == null)
            {
                instance = (Form)Activator.CreateInstance(formType);
                _openedForms.Add(instance);
                this.ucFormViewMain.AddAForm(instance);
                instance.FormClosed += delegate(object sender, FormClosedEventArgs e)
                {
                    _openedForms.Remove(instance);
                };
            }
            return instance;
        }

        public Form GetFirstForm(Type formType)
        {
            if (_openedForms != null && _openedForms.Count > 0)
            {
                foreach (Form frm in _openedForms)
                {
                    if (frm.GetType() == formType) return frm;
                }
            }
            return null;
        }

        /// <summary>
        /// 显示窗口的单个实例，如果之前已经打开过，则只是激活打开过的窗体
        /// </summary>
        /// <param name="formType">要打开的窗体类型</param>
        /// <param name="mainPanel">是否在主面板中打开,否则在从面板中打开</param>
        public T ShowSingleForm<T>() where T : Form
        {
            T instance = null;
            foreach (Form frm in _openedForms)
            {
                if (frm.GetType() == typeof(T))
                {
                    ucFormViewMain.ActiveForm(frm);
                    instance = frm as T;
                    break;
                }
            }
            if (instance == null)
            {
                instance = Activator.CreateInstance(typeof(T)) as T;
                _openedForms.Add(instance);
                this.ucFormViewMain.AddAForm(instance);
                instance.FormClosed += delegate(object sender, FormClosedEventArgs e)
                {
                    _openedForms.Remove(instance);
                };
            }
            return instance;
        }
        #endregion

        #region 事件处理程序
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //ReadSoftDog();
            Authenticate();
            ShowOperatorRights();

            SystemOptions.Current = (new ParameterBLL(AppSettings.CurrentSetting.ConnectString)).GetOrDefaultParameter<SystemOptions>();
            HolidaySetting.Current = new HolidaySetting();
            List<Holiday> holidays = (new HolidayBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
            HolidaySetting.Current.Holidays = holidays;
            AttendanceRules.Current = (new ParameterBLL(AppSettings.CurrentSetting.ConnectString)).GetOrDefaultParameter<AttendanceRules>();

            if (Operator.CurrentOperator != null) this.lblOperator.Text = string.Format(LJH.Attendance.UI.Properties.Resources.FrmMain_lblOperator, Operator.CurrentOperator.Name);
            tmrAutoGenerateResult.Enabled = AppSettings.CurrentSetting.AutoGenerateResult; //
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu_Departments_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmDepartmentMaster));
        }

        private void mnu_AttendanceDoorSelection_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmDeviceInfoMaster));
        }

        private void mnu_Shifts_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftMaster));
        }

        private void mnu_Role_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmRoles));
        }

        private void mnu_Operator_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmOperators));
        }

        private void mnu_ChangePWD_Click(object sender, EventArgs e)
        {
            FrmChangePwd frm = new FrmChangePwd();
            frm.Operator = LJH.Attendance.Model.Operator.CurrentOperator;
            frm.ShowDialog();
        }

        private void mnu_ShiftArrange_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftArrange));
        }

        private void mnu_Options_Click(object sender, EventArgs e)
        {
            FrmSystemOptions frm = new FrmSystemOptions();
            frm.ShowDialog();
            tmrAutoGenerateResult.Enabled = AppSettings.CurrentSetting.AutoGenerateResult;
        }

        private void mnu_Holiday_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmHolidayMaster));
        }

        private void mnu_VacationType_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmVacationTypeMaster));
        }

        private void mnu_OTType_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmOTTypeMaster));
        }

        private void mnu_Aboat_Click(object sender, EventArgs e)
        {
            frmAboat frm = new frmAboat();
            frm.ShowDialog();
        }

        private void mnu_ShiftResultStatistics_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftResultStatistics));
        }

        private void mnu_ResultDayReport_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftResultDayReport));
        }

        private void mnu_ResultMonthReport_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftResultMonthReport));
        }

        private void mnu_Logout_Click(object sender, EventArgs e)
        {
            FrmMain_Load(this, EventArgs.Empty);
        }

        private void mnu_Staff_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmStaffMaster));
        }

        private void mnu_TASheet_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmTASheetGroupMaster));
        }

        private void mnu_AttendanceAnalyst_Click(object sender, EventArgs e)
        {
            List<string> readers = GetAttendanceReaders();
            if (readers == null || readers.Count == 0)
            {
                MessageBox.Show("还未指定考勤点");
                return;
            }
            FrmAttendanceAnalyst frm = new FrmAttendanceAnalyst();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Staff> staffs = frm.Staffs;
                CreateAttendanceResults(staffs, frm.DateRange, readers);

                StaffAttendanceResultSearchCondition con = new StaffAttendanceResultSearchCondition();
                con.ShiftDate = frm.DateRange;
                con.Staff = staffs.Select(it => it.ID).ToList();
                FrmShiftResultDayReport form = ShowSingleForm<FrmShiftResultDayReport>();
                if (form != null)
                {
                    form.Fresh(con);
                }
            }
        }

        private void mnu_ManualLog_Click(object sender, EventArgs e)
        {
            FrmManualLog frm = new FrmManualLog();
            frm.ShowDialog();
        }

        private void mnu_AttendanceLogReport_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmAttendanceLogReport));
        }

        private void mnu_TripType_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmTripTypeMaster));
        }

        private void mnu_AttendanceRules_Click(object sender, EventArgs e)
        {
            FrmAttendanceRules frm = new FrmAttendanceRules();
            frm.ShowDialog();
        }

        private void mnu_ShiftTemplate_Click(object sender, EventArgs e)
        {
            ShowSingleForm(typeof(FrmShiftTemplateMaster));
        }

        private void mnu_BackupData_Click(object sender, EventArgs e)
        {
            FrmBackUp frm = new FrmBackUp();
            frm.ShowDialog();
        }

        private void mnu_UpdateDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要升级数据库?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string path = System.IO.Path.Combine(Application.StartupPath, "DbUpdate.sql");
                if (System.IO.File.Exists(path))
                {
                    try
                    {
                        SqlClient client = new SqlClient(AppSettings.CurrentSetting.ConnectString);
                        client.Connect();
                        client.ExecuteSQLFile(path);
                        MessageBox.Show("数据库升级成功!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                    }
                }
            }
        }

        private void mnu_StaffCategory_Click(object sender, EventArgs e)
        {
            ShowSingleForm<FrmStaffCategoryMaster>();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Operator.CurrentOperator != null)
            {
                DialogResult result;
                result = MessageBox.Show("是否需要退出系统?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) e.Cancel = true;
            }
        }

        private void mnu_ShiftResultMaster_Click(object sender, EventArgs e)
        {
            ShowSingleForm<FrmShiftResultMaster>();
        }
        #endregion

        #region 自动生成考勤结果相关
        private void tmrAutoGenerateResult_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MyTime mt = AppSettings.CurrentSetting.AutoGenerateTime;
            if (mt != null && mt.Hour == dt.Hour && mt.Minute == dt.Minute)
            {
                if (!_HasGenerateResult)
                {
                    _HasGenerateResult = true;
                    List<string> readers = GetAttendanceReaders();
                    if (readers == null || readers.Count == 0)
                    {
                        MessageBox.Show("还未指定考勤点");
                        return;
                    }
                    LJH.GeneralLibrary.LOG.FileLog.Log("自动生成考勤结果", "开始生成考勤结果......");
                    DatetimeRange dr = new DatetimeRange(dt.Date.AddDays(-1), dt.Date.AddSeconds(-1)); //前一天的时间范围
                    List<Staff> staffs = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
                    CreateAttendanceResults(staffs, dr, readers);
                }
            }
            else
            {
                _HasGenerateResult = false;
            }
        }

        private List<string> GetAttendanceReaders()
        {
            List<string> readers = null;
            List<DeviceInfo> attendanceReaders = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).GetAttendanceReaders().QueryObjects;
            if (attendanceReaders == null || attendanceReaders.Count == 0)
            {
                readers = attendanceReaders.Where(it => it.ForAttendance).Select(it => it.ID).ToList();
            }
            return readers;
        }

        private bool CreateAttendanceResult(Staff staff, DatetimeRange dr, List<string> readers)
        {
            ShiftArrangeSearchCondition con1 = new ShiftArrangeSearchCondition();
            con1.StaffID = staff.ID;
            con1.ShiftDate = dr;
            List<ShiftArrange> sas = (new ShiftArrangeBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con1).QueryObjects;

            TASheetSearchCondition con2 = new TASheetSearchCondition();
            con2.StaffID = staff.ID;
            List<TASheet> sheets = (new TASheetBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con2).QueryObjects;

            AttendanceLogSearchCondition con3 = new AttendanceLogSearchCondition();
            con3.Staff = new List<int>();
            con3.Staff.Add(staff.ID);
            con3.Readers = readers;
            con3.ReadDateTime = dr;
            con3.ContainManualLogs = true;
            List<AttendanceLog> records = (new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(con3).QueryObjects;

            List<AttendanceResult> results = (new AttendanceAnalyst()).Analist(staff, sas, records, sheets, dr);
            CommandResult ret = (new AttendanceResultBLL(AppSettings.CurrentSetting.ConnectString)).Add(staff.ID, dr, results);
            return ret.Result == ResultCode.Successful;
        }

        private void CreateAttendanceResults(List<Staff> staffs, DatetimeRange dr, List<string> readers)
        {
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate()
            {
                decimal count = 0;
                try
                {
                    foreach (Staff staff in staffs)
                    {
                        try
                        {
                            frm.ShowProgress(string.Format("正在生成考勤结果 {0}...", staff.Name), count / staffs.Count);
                            count++;
                            bool ret = CreateAttendanceResult(staff, dr, readers);
                            if (ret)
                            {
                                frm.ShowProgress(string.Format("生成考勤结果成功 {0}", staff.Name), count / staffs.Count);
                            }
                            else
                            {
                                frm.ShowProgress(string.Format("生成考勤结果失败 {0}", staff.Name), count / staffs.Count);
                            }
                        }
                        catch (Exception ex)
                        {
                            LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
            };

            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
            DialogResult sdr = frm.ShowDialog();
            if (sdr != DialogResult.OK)
            {
                t.Abort();
            }
            else
            {
                LJH.GeneralLibrary.LOG.FileLog.Log("自动生成考勤结果", "自动生成考勤结果完成");
            }
        }
        #endregion
    }
}
