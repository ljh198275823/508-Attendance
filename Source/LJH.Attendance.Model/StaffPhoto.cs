using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using LJH.GeneralLibrary;

namespace LJH.Attendance.Model
{
    /// <summary>
    /// 表示人员照片
    /// </summary>
    public class StaffPhoto
    {
        #region 构造函数
        public StaffPhoto()
        {
        }

        public StaffPhoto(int staffID, string path)
        {
            StaffID = staffID;
            _Photo = GetBytesFromPhoto(path);
        }

        #endregion

        #region 私有变量
        private byte[] _Photo;

        private Image _Img;
        #endregion

        #region 私有方法
        private Image GetImageFromBytes(byte[] photo)
        {
            try
            {
                if (photo != null)
                {
                    string path = Path.Combine(TempFolderManager.GetCurrentFolder(),
                                        string.Format("{0}_{1}.jpg", "Staff", Guid.NewGuid().ToString()));
                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(photo, 0, photo.Length);
                    }
                    Image img = Image.FromFile(path);
                    return img;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private byte[] GetBytesFromPhoto(string path)
        {

            byte[] bs = null;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    bs = new byte[fs.Length];
                    fs.Position = 0;
                    fs.Read(bs, 0, (int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                LJH.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
            }
            return bs;
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 获取或设置人员ID
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// 获取或设置人员图片
        /// </summary>
        public Image Photo
        {
            get
            {
                if (_Img == null)
                {
                    if (_Photo != null)
                    {
                        _Img = GetImageFromBytes(_Photo);
                    }
                }
                return _Img;
            }
            set
            {
                if (value != null)
                {
                    _Img = value;
                    _Photo = ImageHelper.GetBytesFromPhoto(value);
                }
            }
        }
        #endregion
    }
}
