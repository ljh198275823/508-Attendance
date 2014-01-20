using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;
using LJH.Attendance.BLL;
using LJH.Attendance.Device;

namespace LJH.Attendance.UI
{
    public partial class FrmDeviceInfoMaster : Form
    {
        public FrmDeviceInfoMaster()
        {
            InitializeComponent();
        }

        #region 私有方法
        private void ShowOperatorRights()
        {
            Operator opt = Operator.CurrentOperator;
            if (opt == null) return;
            menu.Items["btn_Add"].Enabled = Operator.CurrentOperator.Permit(Permission.EditAttendanceDevice);
            menu.Items["btn_Delete"].Enabled = Operator.CurrentOperator.Permit(Permission.EditAttendanceDevice);

            mnu_AddDevice1.Enabled = Operator.CurrentOperator.Permit(Permission.EditAttendanceDevice);
            mnu_AddGroup1.Enabled = Operator.CurrentOperator.Permit(Permission.EditDeviceGroup);

            mnu_AddGroup2.Enabled = Operator.CurrentOperator.Permit(Permission.EditDeviceGroup);
            mnu_AddDevice2.Enabled = Operator.CurrentOperator.Permit(Permission.EditAttendanceDevice);
            mnu_Rename2.Enabled = Operator.CurrentOperator.Permit(Permission.EditDeviceGroup);
            mnu_Delete2.Enabled = Operator.CurrentOperator.Permit(Permission.EditDeviceGroup);
            
        }
        #endregion

        #region 事件处理程序
        private void FrmDeviceInfoMaster_Load(object sender, EventArgs e)
        {
            deviceTree1.Init();
            ShowOperatorRights();
        }

        private void deviceTree1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = deviceTree1.GetNodeAt(e.Location);
            if (node != null) deviceTree1.SelectedNode = node;
            if (e.Button == MouseButtons.Right)
            {
                if (node == null || node.Tag == null)
                {
                    deviceTree1.ContextMenuStrip = rootMenu;
                }
                else if (node.Tag is DeviceGroup)
                {
                    deviceTree1.ContextMenuStrip = groupMenu;
                }
                else if (node.Tag is DeviceInfo)
                {
                    deviceTree1.ContextMenuStrip = deviceMenu;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (node != null && node.Tag is DeviceInfo && Operator.CurrentOperator.Permit(Permission.EditAttendanceDevice))
                {
                    deviceTree1.DoDragDrop(node, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }
        }

        private void deviceTree1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.AllowedEffect != DragDropEffects.None) e.Effect = DragDropEffects.Copy;
        }

        private void deviceTree1_DragDrop(object sender, DragEventArgs e)
        {
            Point p = deviceTree1.PointToClient(new Point(e.X, e.Y));
            TreeNode node = deviceTree1.GetNodeAt(p);
            if (node != null && (node.Tag == null || node.Tag is DeviceGroup))
            {
                string[] s = e.Data.GetFormats();
                if (s.Length > 0)
                {
                    object o = e.Data.GetData(s[0]);
                    if (o is TreeNode)
                    {
                        TreeNode copy = o as TreeNode;
                        if (object.ReferenceEquals(copy.Parent, node)) return; //如果只是拖到同一个父节点下，则不用做什么操作
                        if (copy.Tag is DeviceInfo)
                        {
                            DeviceInfo device = copy.Tag as DeviceInfo;
                            DeviceGroup group = node.Tag as DeviceGroup;
                            device.GroupID = group != null ? group.ID : null;
                            CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Update(device);
                            if (ret.Result == ResultCode.Successful)
                            {
                                copy.Parent.Nodes.Remove(copy);
                                node.Nodes.Add(copy);
                            }
                        }
                        else if (copy.Tag is DeviceGroup)
                        {
                            DeviceGroup cg = copy.Tag as DeviceGroup;
                            DeviceGroup group = node.Tag as DeviceGroup;
                            cg.ParentID = group != null ? group.ID : null;
                            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Update(cg);
                            if (ret.Result == ResultCode.Successful)
                            {
                                copy.Parent.Nodes.Remove(copy);
                                node.Nodes.Add(copy);
                            }
                        }
                    }
                }
            }
        }

        private void mnu_AddGroup_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                DeviceGroup group = node.Tag as DeviceGroup;
                FrmDeviceGroupDetail frm = new FrmDeviceGroupDetail();
                frm.ParentGroup = group;
                frm.IsAdding = true;
                frm.ItemAdded += delegate(object o, ItemAddedEventArgs args)
                {
                    DeviceGroup dg = args.AddedItem as DeviceGroup;
                    TreeNode child = new TreeNode();
                    child.Tag = dg;
                    deviceTree1.FreshNode(child);
                    node.Nodes.Add(child);
                    node.Expand();
                };
                frm.ShowDialog();
            }
        }

        private void mnu_AddDevice_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                DeviceGroup group = node.Tag as DeviceGroup;
                FrmDeviceInfoDetail frm = new FrmDeviceInfoDetail();
                frm.ParentGroup = group;
                frm.IsAdding = true;
                frm.ItemAdded += delegate(object o, ItemAddedEventArgs args)
                {
                    DeviceInfo dg = args.AddedItem as DeviceInfo;
                    TreeNode child = new TreeNode();
                    child.Tag = dg;
                    deviceTree1.FreshNode(child);
                    node.Nodes.Add(child);
                    node.Expand();
                };
                frm.ShowDialog();
            }
        }

        private void mnu_Delete_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                if (node.Tag is DeviceGroup)
                {
                    if (node.Nodes.Count == 0)
                    {
                        if (MessageBox.Show("是否要删除？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Delete(node.Tag as DeviceGroup);
                            if (ret.Result == ResultCode.Successful)
                            {
                                node.Parent.Nodes.Remove(node);
                            }
                            else
                            {
                                MessageBox.Show(ret.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("不能删除有子节点的设备组，请先删除此节点下的所有子节点再进行删除操作");
                    }
                }
                else if (node.Tag is DeviceInfo)
                {
                    if (MessageBox.Show("是否要删除？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Delete(node.Tag as DeviceInfo);
                        if (ret.Result == ResultCode.Successful)
                        {
                            node.Parent.Nodes.Remove(node);
                        }
                        else
                        {
                            MessageBox.Show(ret.Message);
                        }
                    }
                }
            }
        }

        private void mnu_Property_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            if (node != null)
            {
                if (node.Tag is DeviceGroup)
                {
                    FrmDeviceGroupDetail frm = new FrmDeviceGroupDetail();
                    frm.IsAdding = false;
                    frm.UpdatingItem = node.Tag;
                    frm.ItemUpdated += delegate(object o, ItemUpdatedEventArgs args)
                    {
                        deviceTree1.FreshNode(node);
                    };
                    frm.ShowDialog();
                }
                else if (node.Tag is DeviceInfo)
                {
                    FrmDeviceInfoDetail frm = new FrmDeviceInfoDetail();
                    frm.IsAdding = false;
                    frm.UpdatingItem = node.Tag;
                    frm.ItemUpdated += delegate(object o, ItemUpdatedEventArgs args)
                    {
                        deviceTree1.FreshNode(node);
                    };
                    frm.ShowDialog();
                }
            }
        }

        private void mnu_Fresh_Click(object sender, EventArgs e)
        {
            deviceTree1.Init();
        }

        private void mnu_Rename_Click(object sender, EventArgs e)
        {
            TreeNode node = this.deviceTree1.SelectedNode;
            deviceTree1.LabelEdit = true;
            if (node.Tag is DeviceGroup)
            {
                node.Text = (node.Tag as DeviceGroup).Name;
            }
            else if (node.Tag is DeviceInfo)
            {
                node.Text = (node.Tag as DeviceInfo).Name;
            }
            node.BeginEdit();
        }

        private void deviceTree1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                TreeNode node = e.Node;
                if (node.Tag is DeviceGroup)
                {
                    DeviceGroup group = node.Tag as DeviceGroup;
                    group.Name = e.Label;
                    CommandResult ret = (new DeviceGroupBLL(AppSettings.CurrentSetting.ConnectString)).Update(group);
                }
                else if (node.Tag is DeviceInfo)
                {
                    DeviceInfo device = node.Tag as DeviceInfo;
                    device.Name = e.Label;
                    CommandResult ret = (new DeviceInfoBLL(AppSettings.CurrentSetting.ConnectString)).Update(device);
                }
            }
            deviceTree1.FreshNode(e.Node);
            e.CancelEdit = true; //这一行不能省
            deviceTree1.LabelEdit = false;
        }

        private void mnu_UploadAll_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            DeviceInfo device = node.Tag as DeviceInfo;
            if (device == null) return;
            ZKFingerKeeper keeper = new ZKFingerKeeper(device);
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate()
            {
                keeper.Connect();
                if (keeper.IsConnected)
                {
                    try
                    {
                        keeper.EnableDevice(false);
                        //清空控制器
                        frm.ShowProgress("正在清空设备...", 0);
                        keeper.ClearData(ClearDataFlag.UserInfo);
                        keeper.ClearData(ClearDataFlag.FPTemplate);
                        frm.ShowProgress("清空设备成功", 0.1m);
                        decimal count = 0;
                        frm.ShowProgress("开始上传人员...", 0);
                        List<Staff> staff = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetItems(null).QueryObjects;
                        List<StaffBioTemplate> templates = (new StaffBLL(AppSettings.CurrentSetting.ConnectString)).GetBioTemplates(null).QueryObjects;
                        for (int i = 0; i < staff.Count; i++)
                        {
                            keeper.SetUserInfo(staff[i]);
                            List<StaffBioTemplate> temp = templates.Where(item => item.StaffID == staff[i].ID).ToList();
                            if (temp != null && temp.Count > 0)
                            {
                                foreach (StaffBioTemplate template in temp)
                                {
                                    keeper.SetUserTemplate(template);
                                }
                            }
                            count++;
                            frm.ShowProgress(string.Format("上传人员 {0}", staff[i].Name), count / staff.Count);
                        }
                        keeper.RefreshData();
                    }
                    catch (ThreadAbortException)
                    {
                    }
                    catch (Exception ex)
                    {
                        LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                    }
                    finally
                    {
                        keeper.EnableDevice(true);
                        keeper.Disconnect();
                    }
                }
                else
                {
                    frm.ShowProgress("连接设备失败", 1);
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.Start();
            frm.ShowDialog();
        }

        private void mnu_SyncTime_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            DeviceInfo device = node.Tag as DeviceInfo;
            if (device == null) return;
            ZKFingerKeeper keeper = new ZKFingerKeeper(device);
            keeper.Connect();
            if (keeper.IsConnected)
            {
                keeper.SetTime(DateTime.Now);
            }
            keeper.Disconnect();
        }

        private void mnu_Upload_Click(object sender, EventArgs e)
        {

        }

        private void mnu_GetAttendanceLog_Click(object sender, EventArgs e)
        {
            TreeNode node = deviceTree1.SelectedNode;
            DeviceInfo device = node.Tag as DeviceInfo;
            if (device == null) return;
            ZKFingerKeeper keeper = new ZKFingerKeeper(device);
            FrmProcessing frm = new FrmProcessing();
            Action action = delegate()
            {
                keeper.Connect();
                if (keeper.IsConnected)
                {
                    try
                    {
                        //清空控制器
                        frm.ShowProgress("正在获取考勤记录...", 0);
                        List<AttendanceLog> logs = keeper.GetAttendanceLogs(null);
                        if (logs == null || logs.Count == 0) frm.ShowProgress("没有获取到考勤记录,请查看相关的日志文件查看错误信息", 1);
                        frm.ShowProgress(string.Format("获取到 {0} 条考勤记录,正在努力保存考勤记录...", logs.Count), 0.99m);
                        AttendanceLogBLL bll = new AttendanceLogBLL(AppSettings.CurrentSetting.ConnectString);
                        int count = 0;
                        foreach (AttendanceLog log in logs)
                        {
                            count++;
                            frm.ShowProgress(string.Format("正在保存第 {0} 条记录", count), (decimal)count / logs.Count);
                            CommandResult ret = bll.Add(log);
                        }
                        frm.ShowProgress("完成", 1);
                    }
                    catch (ThreadAbortException)
                    {
                    }
                    catch (Exception ex)
                    {
                        LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                    }
                    finally
                    {
                        keeper.Disconnect();
                    }
                }
                else
                {
                    frm.ShowProgress("连接设备失败", 1);
                }
            };
            Thread t = new Thread(new ThreadStart(action));
            t.Start();
            frm.ShowDialog();
        }
        #endregion
    }
}
