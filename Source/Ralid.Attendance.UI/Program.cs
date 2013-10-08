using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ralid.GeneralLibrary;

namespace Ralid.Attendance.UI
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

            if (Ralid.GeneralLibrary.SingleInstance.OpenSingleProcess())
            {
                Form frm = new FrmMain();
                Application.Run(frm);
            }
            else
            {
                Ralid.GeneralLibrary.SingleInstance.ShowSingleProcess();
            }
        }
    }
}
