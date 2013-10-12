using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LJH.Attendance.Model;
using LJH.Attendance.Model.Result;

namespace LJH.Attendance.UI
{
    public partial class FrmDetailBase : Form
    {
        public FrmDetailBase()
        {
            InitializeComponent();
        }


        public bool IsAdding { get; set; }
        public object UpdatingItem { get; set; }
        public event EventHandler<ItemUpdatedEventArgs> ItemUpdated;
        public event EventHandler<ItemAddedEventArgs> ItemAdded;

        #region 模板方法
        protected virtual bool CheckInput()
        {
            throw new NotImplementedException("子类没有重写CheckInput方法");
        }

        protected virtual void InitControls()
        {
            
        }
        protected virtual void ItemShowing()
        {
            
        }

        protected virtual Object GetItemFromInput()
        {
            throw new NotImplementedException("子类没有重写GetItemFromInput方法");
        }

        protected virtual CommandResult  AddItem(object addingItem)
        {
            throw new NotImplementedException("子类没有重写AddItem方法");
        }

        protected virtual CommandResult UpdateItem(object updatingItem)
        {
            throw new NotImplementedException("子类没有重写UpdateItem方法");
        }
        #endregion

        private void FrmDetailBase_Load(object sender, EventArgs e)
        {
            InitControls();
            if (!IsAdding)
            {
                ItemShowing();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    object item = GetItemFromInput();
                    if (item != null)
                    {
                        CommandResult result = null;
                        if (IsAdding)
                        {
                            result = AddItem(item);
                            if (result.Result == ResultCode.Successful)
                            {
                                if (this.ItemAdded != null) this.ItemAdded(this, new ItemAddedEventArgs(item));
                                this.Close();
                            }
                        }
                        else
                        {
                            result = UpdateItem(item);
                            if (result.Result == ResultCode.Successful)
                            {
                                if (this.ItemUpdated != null) this.ItemUpdated(this, new ItemUpdatedEventArgs(item));
                                this.Close();
                            }
                        }

                        if (result.Result != ResultCode.Successful)
                        {
                            MessageBox.Show(result.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        protected void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
