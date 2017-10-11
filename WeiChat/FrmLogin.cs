/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2013-12-08
 * * 说明：FrmLogin.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.Runtime.InteropServices;
using System.Threading;
using CC2013.Properties;
using System.Diagnostics;
using CCWin.Win32;
using System.Xml;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace Wechat
{
    public partial class FrmLogin : CCSkinMain
    {
        #region 声明

        private readonly string logXmlPath = @"Back\DateData.xml"; //登录XML
        private readonly string CityXmlPath = @"Back\Cities.xml"; //城市代码XML
        private readonly string runPath = System.AppDomain.CurrentDomain.BaseDirectory; //当前应用程序基目录
        private User_Param userParam; //传递参数

        #endregion

        #region 构造

        public FrmLogin()
        {
            InitializeComponent();
            //订阅自定义事件
            Helper.eventSend += new SendHandler(ReceiveParam);
        }

        #endregion

        #region Load事件
        //窗口加载时
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int H = DateTime.Now.Hour;
            this.Back =
                H > 5 & H <= 11 ? Resources.morning :     //早上
                H > 11 & H <= 16 ? Resources.noon :       //中午
                H > 16 & H <= 19 ? Resources.afternoon :      //下午
                Resources.night;        //晚上
            //加载Id下拉框
            //SetId();
            GetUser(logXmlPath, true);
        }

        //加载Id下拉框
        Random rnd = new Random();
        private void SetId()
        {
            for (int i = 0; i < 6; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.AutoSize = false;
                item.Size = new System.Drawing.Size(182, 45);
                item.Tag = rnd.Next(1000, 10000).ToString();
                item.Text = "威廉乔克斯_汀\n" + rnd.Next(1000, 10000).ToString();
                item.Image = Image.FromFile("head/" + rnd.Next(1, 11) + ".png");
                item.Click += new EventHandler(item_Click);
                MenuId.Height += 45;
                MenuId.Items.Add(item);
            }
        }

        #endregion

        #region 监听事件

        void ReceiveParam(object sender, object msg)
        {
            Type t = msg.GetType();
            if (t.IsEnum)
            {
                eFrom e = (eFrom)msg;
                switch (e)
                {
                    case eFrom.Show_Main:
                        ShowMainFrm(sender as User_Param);
                        break;
                }
            }
        }

        #endregion

        #region 读取样例XML
        private void GetUser(string logXmlPath, bool isExpand)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(logXmlPath);
                XmlNodeList dateData = doc.DocumentElement.ChildNodes;
                foreach (XmlNode Qd in dateData)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.AutoSize = false;
                    item.Size = new System.Drawing.Size(182, 45);
                    item.Tag = Qd.Attributes["id"].Value;
                    item.Text = Qd.Attributes["nickname"].Value + "\r\n" + Qd.Attributes["id"].Value;
                    item.Image = Image.FromFile("head/" + rnd.Next(1, 11) + ".png");
                    item.Click += new EventHandler(item_Click);
                    MenuId.Height += 45;
                    MenuId.Items.Add(item);
                }
            }
            catch (Exception A)
            {
                Console.WriteLine("Exception: {0}", A.ToString());
            }

        }

        #endregion

        #region 登录事件
        //登录事件
        FrmMain main;
        private void btnDl_Click(object sender, EventArgs e)
        {
            if (txtId.SkinTxt.Text.Length == 0 || txtPwd.SkinTxt.Text.Length == 0) 
            {
                pwdErro.Left = (this.Width - pwdErro.Width) / 2;
                pwdErro.Visible = true;
                return;
            }
            imgLoadding.Visible = true;
            //登录后控件相关处理
            txtId.Visible = txtPwd.Visible = btnZc.Visible = btnMima.Visible =
                btnId.Visible = chkMima.Visible = chkZdLogin.Visible =
                btnDuoId.Visible = btnSw.Visible = btnState.Enabled = false;
            btnDl.Enabled = false;
            //头像局中
            pnlTx.Left = (this.Width - pnlTx.Width) / 2;
            //准备参数
            userParam = new User_Param();
            userParam.Id = txtId.SkinTxt.Text.Trim();
            userParam.HeadImg = pnlImgTx.BackgroundImage;
            userParam.BtnState = btnState;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(GetLog), txtId.SkinTxt.Text);
            //timShow.Start();
        }

        #endregion

        #region 获取上次登录与天气信息

        private void GetLog(object o)
        {
            try
            {
                string loginId = o as string;
                string showText = string.Empty;
                IpStat ipStat = null;
                XmlDocument doc = new XmlDocument();
                doc.Load(logXmlPath);
                XmlNodeList dateData = doc.DocumentElement.ChildNodes;
                bool flag = false; //标识是否找到帐号 
                foreach (XmlNode subNode in dateData)
                {
                    if (loginId == subNode.Attributes["id"].Value)
                    {
                        flag = true;
                        ipStat = WriteXml(doc, subNode);
                        break;
                    }

                }

                //新用户
                if (!flag)
                {
                    XmlElement node = doc.CreateElement("Info");
                    XmlNode attr = doc.CreateNode(XmlNodeType.Attribute, "id", null);
                    attr.Value = txtId.SkinTxt.Text;
                    node.Attributes.SetNamedItem(attr);

                    attr = doc.CreateNode(XmlNodeType.Attribute, "nickname", null);
                    attr.Value = "新用户";
                    node.Attributes.SetNamedItem(attr);

                    attr = doc.CreateNode(XmlNodeType.Attribute, "text", null);
                    attr.Value = "这家伙很懒，什么都没写。";
                    node.Attributes.SetNamedItem(attr);
                    doc.DocumentElement.AppendChild(node);

                    ipStat = WriteXml(doc, node);
                }

                /***以下二选一***/
                //string[] s = GetWeatherByWebSevice(ipStat); //调用WebService
                //string[] s = GetWeatherByWebSeviceUrl(ipStat); //调用WebServiceURL
                /***End***/


                //if (s != null)
                {
                    //WeatherGet.DisWeatherInfo(userParam, s); //分解天气信息与获取背景图
                }

                Helper.SendMessage(userParam, eFrom.Show_Main);

            }
            catch (Exception A)
            {
                Console.WriteLine("Exception: {0}", A.ToString());
            }


        }

        #endregion

        #region 回写XML

        private IpStat WriteXml(XmlDocument doc, XmlNode subNode)
        {
            XmlNode firstChild = subNode.FirstChild;

            string ipAddress = string.Empty;

            //使用公网IP
            ipAddress = Helper.GetPublicIP();

            Regex rx = new Regex(@"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))");

            //没有公网IP使用内网
            if (string.IsNullOrEmpty(ipAddress) && !rx.IsMatch(ipAddress))
            {

                //获取本机的IP
                System.Net.IPAddress[] addressList = Dns.GetHostAddresses(Dns.GetHostName());
                //IPAddress ipa = addressList[0];
                IPAddress ipa = null;
                for (int i = 0; i < addressList.Length; i++)
                {
                    if (addressList[i].AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
                    {
                        ipa = addressList[i];//获得IP4地址
                        break;
                    }
                }
                ipAddress = ipa.ToString();
            }


            //保存IP信息到类中（可扩展）
            //IpStat ipStat = new IpStat();
            //WryLocator ipWry = new WryLocator(runPath + @"Back\qqwry.dat");
            //IPLocation ip = ipWry.Query(ipAddress);
            //ipStat.IP = ipAddress;
            //ipStat.IpSrc = ipSrc;
            //ipStat.Country = ip.Country;
            //if (ip.Local.Contains("CZ88.NET"))
            //{
            //    ip.Local = "本机";
            //}
            //ipStat.Local = ip.Local;
            //ipStat.CreateTime = DateTime.Now;
            //BLL.IpStatManager.Insert(ipStat); //写入数据库

            //写入XML里
            WryLocator ipWry = new WryLocator(runPath + @"Back\qqwry.dat");

            IPLocation ip = ipWry.Query(ipAddress);
            //IPLocation ip = ipWry.Query("202.175.82.92");

            if (ip.Local.Contains("CZ88.NET"))
            {
                ip.Local = "本机";
            }
            XmlElement newNode = doc.CreateElement("History");
            XmlNode attr = doc.CreateNode(XmlNodeType.Attribute, "ip", null);
            attr.Value = ipAddress;
            newNode.Attributes.SetNamedItem(attr);

            attr = doc.CreateNode(XmlNodeType.Attribute, "local", null);
            attr.Value = ip.Local;
            newNode.Attributes.SetNamedItem(attr);

            attr = doc.CreateNode(XmlNodeType.Attribute, "country", null);
            attr.Value = ip.Country;
            newNode.Attributes.SetNamedItem(attr);

            attr = doc.CreateNode(XmlNodeType.Attribute, "time", null);
            //attr.Value = DateTime.Now.ToString();
            attr.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            newNode.Attributes.SetNamedItem(attr);

            attr = doc.CreateNode(XmlNodeType.Attribute, "remark", null);
            attr.Value = string.Empty;
            newNode.Attributes.SetNamedItem(attr);

            userParam.IpStat = new IpStat();

            if (firstChild != null)
            {
                userParam.IpStat.IP = firstChild.Attributes["ip"].Value;
                userParam.IpStat.Country = firstChild.Attributes["country"].Value;
                //userParam.IpStat.Local = firstChild.Attributes["local"].Value;
                userParam.IpStat.CreateTime = Convert.ToDateTime(firstChild.Attributes["time"].Value);

                subNode.InsertBefore(newNode, firstChild);
            }
            else
            {
                subNode.AppendChild(newNode);
            }

            userParam.IpStat.Local = ip.Country; //当前的位置

            doc.Save(logXmlPath);

            return userParam.IpStat;
        }

        #endregion

        #region 获取天气

        private void GetWeather(IpStat ipStat)
        {
            if (ipStat == null)
            {
                return;
            }

            string local = WeatherGet.GetCity(ipStat.Local); //分解省市

            if (!string.IsNullOrEmpty(local))
            {
                ipStat.Local = local; //赋值给参数类

                //获取《中国气象网》的代码号
                string code = string.Empty; //天气代码号
                XmlDocument doc = new XmlDocument();
                doc.Load(CityXmlPath);//加载文件
                XmlNodeList data = doc.DocumentElement.ChildNodes;
                foreach (XmlNode xnf in data)
                {
                    XmlElement xe = (XmlElement)xnf;
                    if (xe.InnerText == ipStat.Local)
                    {
                        XmlElement xmlCode = (XmlElement)xe.NextSibling;
                        code = xmlCode.InnerText;
                        userParam.WeatherList = WeatherGet.GetThreeDayWeather(code); //近三天天气放入参数
                        break;
                    }
                }
            }

        }

        #endregion

        #region WebSevice获取天气

        private string[] GetWeatherByWebSevice(IpStat ipStat)
        {
            if (ipStat == null)
            {
                return null;
            }

            string local = WeatherGet.GetCity(ipStat.Local); //分解省市

            if (!string.IsNullOrEmpty(local))
            {
                ipStat.Local = local; //赋值给参数类
                return WeatherGet.GetByWebSevice(local);
            }

            return null;
        }

        #endregion

        #region WebSeviceURL获取天气

        private string[] GetWeatherByWebSeviceUrl(IpStat ipStat)
        {
            if (ipStat == null)
            {
                return null;
            }

            string local = WeatherGet.GetCity(ipStat.Local); //分解省市

            if (!string.IsNullOrEmpty(local))
            {
                ipStat.Local = local; //赋值给参数类
                return WeatherGet.GetByWebSeviceUrl(local);
            }

            return null;
        }

        #endregion

        #region 委托显示窗体

        delegate void ShowMainFrmEventHandler(User_Param userParam);
        private void ShowMainFrm(User_Param userParam)
        {
            if (this.InvokeRequired)
            {
                ShowMainFrmEventHandler cb = new ShowMainFrmEventHandler(ShowMainFrm);
                this.Invoke(cb, new object[] { userParam });
            }
            else
            {
                this.Hide();
                main = new FrmMain(userParam);
                main.Show();
            }

        }

        #endregion

        #region 滚动条计时器(进入主窗)

        //滚动条计时器
        private void timShow_Tick(object sender, EventArgs e)
        {
            //this.Hide();
            //tuopan.Text = String.Format("QQ：{0}({1})", txtId.SkinTxt.Text, txtId.SkinTxt.Text);
            //main = new FrmMain(txtId.SkinTxt.Text, pnlImgTx.BackgroundImage, btnState);
            //main.Show();
            //System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(GetLog), txtId.SkinTxt.Text);
            //timShow.Stop();

        }

        #endregion

        #region 其它
        //状态菜单中的Item选择事件
        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            txtId.SkinTxt.Text = item.Tag.ToString();
            pnlImgTx.BackgroundImage = item.Image;
        }

        //悬浮时
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            txtId.MouseState = ControlState.Hover;
        }

        //离开时
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            txtId.MouseState = ControlState.Normal;
        }

        //托盘图标双击显示
        private void tuopan_DoubleClick(object sender, EventArgs e)
        {
            if (main != null)
            {
                main.Show();
            }
            else
            {
                this.Show();
            }
        }

        //选择状态
        private void btnState_Click(object sender, EventArgs e)
        {
            MenuState.Show(btnState, 0, btnState.Height + 5);
        }

        //状态选择项
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            btnState.Image = Item.Image;
            btnState.Tag = Item.Tag;
        }

        //账号下拉框按钮事件
        private void btnId_MouseDown(object sender, MouseEventArgs e)
        {
            MenuId.Show(txtId, 1, txtId.Height + 1);
            btnId.StopState = StopStates.Pressed;
            btnId.Enabled = false;
            txtId.MouseState = ControlState.Hover;
        }

        //账号下拉菜单关闭时
        private void MenuId_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            btnId.Enabled = true;
            btnId.StopState = StopStates.NoStop;
            btnId.ControlState = txtId.MouseState = ControlState.Normal;
        }

        //软键盘
        private void txtPwd_IconClick(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + txtPwd.Left - 25, this.Top + txtPwd.Bottom, txtPwd.SkinTxt);
            pass.Show(this);
        }

        //自动登录
        private void chkZdLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkMima.Checked = chkZdLogin.Checked ? true : chkMima.Checked;
        }

        //记住密码
        private void chkMima_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMima.Checked && chkZdLogin.Checked)
            {
                chkZdLogin.Checked = false;
            }
        }

        //关闭
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //找回密码
        private void btnMima_Click(object sender, EventArgs e)
        {
            Process.Start("https://aq.qq.com/cn2/findpsw/pc/pc_find_pwd_input_account?source_id=1003&ptlang=2052&aquin=");
        }

        //注册账号
        private void btnZc_Click(object sender, EventArgs e)
        {
            Process.Start("http://zc.qq.com/chs/index.html?from=client&ptlang=2052&regkey=&ADUIN=0&ADSESSION=0&ADTAG=CLIENT.QQ.5065_NewAccount_Btn.0&ADPUBNO=26154");
        }

        ////账号框失去焦点时，转入密码框
        //private void txtId_Leave(object sender, EventArgs e)
        //{
        //    txtPwd.Focus();
        //}

        string newLine = Environment.NewLine;
        private void btnMbShow_Click(object sender, EventArgs e)
        {
            string info = "简单文字信息................" + newLine +
             "简单文字信息................";
            MessageBoxEx.Show(info);
            MessageBoxEx.Show(info, "带标题的示例");
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            MessageBoxEx.Show(info, "带标题的示例",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }

        #endregion
    }
}