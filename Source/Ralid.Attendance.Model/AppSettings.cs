﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Ralid.Attendance.Model
{

    public class AppSettings
    {
        /// <summary>
        /// 获取或设置系统的当前设置
        /// </summary>
        public static AppSettings CurrentSetting
        {
            get
            {
                if (_instance == null)
                    _instance = new AppSettings(Application.ExecutablePath + ".config");
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        #region 私有变量
        private static AppSettings _instance = null;
        private XmlDocument _doc = null;
        private XmlNode _parent = null;
        private string _path;

        private string _ConnectString;
        private bool _DatabaseNeedUpgrade;
        private bool _NeedPasswordWhenExit;
        private string _Language;
        private bool _RememberLogID;
        #endregion

        #region 构造函数
        public AppSettings(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string temp = string.Empty;
                    _path = path;
                    this._doc = new XmlDocument();
                    this._doc.Load(_path);
                    _parent = this._doc.SelectSingleNode("configuration/appSettings");

                    _ConnectString = GetConfigContent("ConnectString");

                    temp = GetConfigContent("DatabaseNeedUpgrade");
                    bool.TryParse(temp, out _DatabaseNeedUpgrade);

                    temp = GetConfigContent("NeedPasswordWhenExit");
                    bool.TryParse(temp, out _NeedPasswordWhenExit);

                    _Language = GetConfigContent("Language");

                    temp = GetConfigContent("RememberLogID");
                    bool.TryParse(temp, out _RememberLogID);
                }
                catch
                {
                }
            }
        }
        #endregion

        #region 公共属性
      
        /// <summary>
        /// 获取当前选择数据库的数据库连接字符串
        /// </summary>
        public string ConnectString
        {
            //连接字串分两段加密，首先前8个字符为加密的日期，做为实际连接字符串信息的加密密码。
            //解密连接字串：先用默认加密密码的加密类型解密出前8个字符的明文，再用一个密码为此明文的加密类解密出后续字符，得到连接字符的明文。
            get
            {
                string con = string.Empty;
                if (!string.IsNullOrEmpty(_ConnectString) && _ConnectString.Length > 8)
                {
                    con = (new Ralid.GeneralLibrary.SoftDog.DTEncrypt()).DSEncrypt(_ConnectString);
                }
                return con;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ConnectString = (new Ralid.GeneralLibrary.SoftDog.DTEncrypt()).Encrypt(value);
                    SaveConfig("ConnectString", _ConnectString);
                }
                else
                {
                    SaveConfig("ConnectString", string.Empty);
                }
            }
        }
        /// <summary>
        /// 获取或设置数据库是否需要升级
        /// </summary>
        public bool DatabaseNeedUpgrade
        {
            get
            {
                return _DatabaseNeedUpgrade;
            }
            set
            {
                if (_DatabaseNeedUpgrade != value)
                {
                    _DatabaseNeedUpgrade = value;
                    SaveConfig("DatabaseNeedUpgrade", value.ToString());
                }
            }
        }

        /// <summary>
        /// 获取或设置系统的语言
        /// </summary>
        public string Language
        {
            get { return _Language; }
            set
            {
                if (_Language != value)
                {
                    _Language = value;
                    SaveConfig("Language", value);
                }
            }
        }
        /// <summary>
        /// 获取或设置登录时是否记录登录名
        /// </summary>
        public bool RememberLogID
        {
            get { return _RememberLogID; }
            set
            {
                if (_RememberLogID != value)
                {
                    _RememberLogID = value;
                    SaveConfig("RememberLogID", _RememberLogID.ToString());
                }
            }
        }

        public bool SaveConfig(string configName, string configContent)
        {
            if (_parent != null)
            {
                try
                {
                    XmlElement add = null;
                    XmlAttribute key = null;
                    XmlAttribute value = null;
                    XmlNodeList nodeList = _parent.ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {
                        if (xn is XmlElement)
                        {
                            XmlElement xe = (XmlElement)xn;
                            if (xe.GetAttribute("key") == configName)
                            {
                                xe.SetAttribute("value", configContent);
                                add = xe;
                                break;
                            }
                        } // end if
                    }
                    if (add == null)
                    {
                        add = _doc.CreateElement("add");
                        key = _doc.CreateAttribute("key");
                        key.Value = configName;
                        value = _doc.CreateAttribute("value");
                        value.Value = configContent;

                        add.Attributes.Append(key);
                        add.Attributes.Append(value);
                        _parent.AppendChild(add);
                    }
                    this._doc.Save(_path.ToString());
                    return true;
                }
                catch (Exception ex)
                {
                    Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                }
            }
            return false;
        }

        public string GetConfigContent(string configName)
        {
            if (_parent != null)
            {
                try
                {
                    XmlNodeList nodeList = _parent.ChildNodes;
                    foreach (XmlNode xn in nodeList)
                    {                        
                        if (xn is XmlElement)
                        {
                            XmlElement xe = (XmlElement)xn;
                            if (xe.GetAttribute("key") == configName)
                            {
                                return xe.GetAttribute("value");
                            }
                        } // end if
                    }
                }
                catch (Exception ex)
                {
                    Ralid.GeneralLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex);
                }
            }
            return "";
        }
        #endregion
    }
}
