using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LJH.Attendance.UI;

namespace AttendanceDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!LJH.GeneralLibrary.SingleInstance.ExistsProcess())
            {
                Form frm = new FrmMainDemo();
                Application.Run(frm);
            }
            else
            {
                LJH.GeneralLibrary.SingleInstance.ShowSingleProcess();
            }
        }
    }
}
