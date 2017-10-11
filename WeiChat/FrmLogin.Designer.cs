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
 * * 说明：FrmLogin.Designer.cs
 * *
********************************************************************/

namespace Wechat
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            this.toolShow = new System.Windows.Forms.ToolTip(this.components);
            this.btnDuoId = new CCWin.SkinControl.SkinButton();
            this.btnSw = new CCWin.SkinControl.SkinButton();
            this.chkZdLogin = new CCWin.SkinControl.SkinCheckBox();
            this.btnMima = new CCWin.SkinControl.SkinButton();
            this.btnZc = new CCWin.SkinControl.SkinButton();
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.QQMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolQQShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuState = new CCWin.SkinControl.SkinContextMenuStrip();
            this.ItemImonline = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemAway = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemInVisble = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuId = new CCWin.SkinControl.SkinContextMenuStrip();
            this.chkMima = new CCWin.SkinControl.SkinCheckBox();
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.btnMbShow = new CCWin.SkinControl.SkinButton();
            this.btnDl = new CCWin.SkinControl.SkinButton();
            this.txtId = new CCWin.SkinControl.SkinTextBox();
            this.btnId = new CCWin.SkinControl.SkinButton();
            this.pwdErro = new CC2013.PwdErro();
            this.txtPwd.SuspendLayout();
            this.pnlTx.SuspendLayout();
            this.pnlImgTx.SuspendLayout();
            this.QQMenu.SuspendLayout();
            this.MenuState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            this.txtId.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDuoId
            // 
            this.btnDuoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuoId.BackColor = System.Drawing.Color.Transparent;
            this.btnDuoId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDuoId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDuoId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.DownBack")));
            this.btnDuoId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDuoId.Location = new System.Drawing.Point(15, 257);
            this.btnDuoId.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuoId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.MouseBack")));
            this.btnDuoId.Name = "btnDuoId";
            this.btnDuoId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.NormlBack")));
            this.btnDuoId.Size = new System.Drawing.Size(25, 25);
            this.btnDuoId.TabIndex = 9;
            this.toolShow.SetToolTip(this.btnDuoId, "多帐号登录");
            this.btnDuoId.UseVisualStyleBackColor = false;
            // 
            // btnSw
            // 
            this.btnSw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSw.BackColor = System.Drawing.Color.Transparent;
            this.btnSw.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnSw.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSw.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSw.DownBack")));
            this.btnSw.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSw.Location = new System.Drawing.Point(335, 248);
            this.btnSw.Margin = new System.Windows.Forms.Padding(0);
            this.btnSw.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSw.MouseBack")));
            this.btnSw.Name = "btnSw";
            this.btnSw.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSw.NormlBack")));
            this.btnSw.Size = new System.Drawing.Size(38, 38);
            this.btnSw.TabIndex = 10;
            this.toolShow.SetToolTip(this.btnSw, "二维码登录");
            this.btnSw.UseVisualStyleBackColor = false;
            // 
            // chkZdLogin
            // 
            this.chkZdLogin.AutoSize = true;
            this.chkZdLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkZdLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkZdLogin.DefaultCheckButtonWidth = 15;
            this.chkZdLogin.DownBack = global::CC2013.Properties.Resources.checkbox_pushed;
            this.chkZdLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkZdLogin.ForeColor = System.Drawing.Color.Black;
            this.chkZdLogin.LightEffect = false;
            this.chkZdLogin.Location = new System.Drawing.Point(193, 208);
            this.chkZdLogin.MouseBack = global::CC2013.Properties.Resources.checkbox_hightlight;
            this.chkZdLogin.Name = "chkZdLogin";
            this.chkZdLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.NormlBack")));
            this.chkZdLogin.SelectedDownBack = global::CC2013.Properties.Resources.checkbox_tick_pushed;
            this.chkZdLogin.SelectedMouseBack = global::CC2013.Properties.Resources.checkbox_tick_highlight;
            this.chkZdLogin.SelectedNormlBack = global::CC2013.Properties.Resources.checkbox_tick_normal;
            this.chkZdLogin.Size = new System.Drawing.Size(75, 21);
            this.chkZdLogin.TabIndex = 4;
            this.chkZdLogin.Text = "自动登录";
            this.chkZdLogin.UseVisualStyleBackColor = false;
            this.chkZdLogin.CheckedChanged += new System.EventHandler(this.chkZdLogin_CheckedChanged);
            // 
            // btnMima
            // 
            this.btnMima.BackColor = System.Drawing.Color.Transparent;
            this.btnMima.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMima.Create = true;
            this.btnMima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMima.DownBack = global::CC2013.Properties.Resources.mima_press;
            this.btnMima.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnMima.Location = new System.Drawing.Point(308, 180);
            this.btnMima.Margin = new System.Windows.Forms.Padding(0);
            this.btnMima.MouseBack = global::CC2013.Properties.Resources.mima_hover;
            this.btnMima.Name = "btnMima";
            this.btnMima.NormlBack = global::CC2013.Properties.Resources.mima;
            this.btnMima.Size = new System.Drawing.Size(51, 16);
            this.btnMima.TabIndex = 7;
            this.btnMima.UseVisualStyleBackColor = false;
            this.btnMima.Click += new System.EventHandler(this.btnMima_Click);
            // 
            // btnZc
            // 
            this.btnZc.BackColor = System.Drawing.Color.Transparent;
            this.btnZc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnZc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnZc.Create = true;
            this.btnZc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZc.DownBack = global::CC2013.Properties.Resources.zhuce_press;
            this.btnZc.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnZc.Location = new System.Drawing.Point(309, 145);
            this.btnZc.Margin = new System.Windows.Forms.Padding(0);
            this.btnZc.MouseBack = global::CC2013.Properties.Resources.zhuce_hover;
            this.btnZc.Name = "btnZc";
            this.btnZc.NormlBack = global::CC2013.Properties.Resources.zhuce;
            this.btnZc.Size = new System.Drawing.Size(51, 16);
            this.btnZc.TabIndex = 6;
            this.btnZc.UseVisualStyleBackColor = false;
            this.btnZc.Click += new System.EventHandler(this.btnZc_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.Icon = global::CC2013.Properties.Resources.imgRjp_BackgroundImage;
            this.txtPwd.IconIsButton = true;
            this.txtPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.Location = new System.Drawing.Point(112, 174);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtPwd.MouseBack = null;
            this.txtPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = null;
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // txtPwd.BaseText
            // 
            this.txtPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPwd.SkinTxt.Name = "BaseText";
            this.txtPwd.SkinTxt.PasswordChar = '●';
            this.txtPwd.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtPwd.SkinTxt.TabIndex = 0;
            this.txtPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.SkinTxt.WaterText = "密码";
            this.txtPwd.TabIndex = 33;
            this.txtPwd.IconClick += new System.EventHandler(this.txtPwd_IconClick);
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTx.BackgroundImage")));
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.pnlImgTx);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = null;
            this.pnlTx.Location = new System.Drawing.Point(15, 140);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = null;
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = null;
            this.pnlTx.Size = new System.Drawing.Size(87, 87);
            this.pnlTx.TabIndex = 12;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = global::CC2013.Properties.Resources._1_100;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.Controls.Add(this.btnState);
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(1, 1);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pnlImgTx.Size = new System.Drawing.Size(85, 85);
            this.pnlImgTx.TabIndex = 11;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = global::CC2013.Properties.Resources.allbtn_down;
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = global::CC2013.Properties.Resources.imonline__2_;
            this.btnState.ImageSize = new System.Drawing.Size(11, 11);
            this.btnState.Location = new System.Drawing.Point(67, 67);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = global::CC2013.Properties.Resources.allbtn_highlight;
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Size = new System.Drawing.Size(18, 18);
            this.btnState.TabIndex = 11;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // tuopan
            // 
            this.tuopan.ContextMenuStrip = this.QQMenu;
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Text = "CC";
            this.tuopan.Visible = true;
            this.tuopan.DoubleClick += new System.EventHandler(this.tuopan_DoubleClick);
            // 
            // QQMenu
            // 
            this.QQMenu.Arrow = System.Drawing.Color.Black;
            this.QQMenu.AutoSize = false;
            this.QQMenu.Back = System.Drawing.Color.White;
            this.QQMenu.BackRadius = 4;
            this.QQMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.QQMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QQMenu.Fore = System.Drawing.Color.Black;
            this.QQMenu.HoverFore = System.Drawing.Color.White;
            this.QQMenu.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.QQMenu.ItemAnamorphosis = false;
            this.QQMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemBorderShow = false;
            this.QQMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.QQMenu.ItemRadius = 4;
            this.QQMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.QQMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolQQShow,
            this.toolStripMenuItem3,
            this.toolExit});
            this.QQMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QQMenu.Name = "MenuState";
            this.QQMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.QQMenu.Size = new System.Drawing.Size(120, 53);
            this.QQMenu.SkinAllColor = true;
            this.QQMenu.TitleAnamorphosis = false;
            this.QQMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.QQMenu.TitleRadius = 4;
            this.QQMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolQQShow
            // 
            this.toolQQShow.AutoSize = false;
            this.toolQQShow.Name = "toolQQShow";
            this.toolQQShow.Size = new System.Drawing.Size(119, 22);
            this.toolQQShow.Text = "打开主面板";
            this.toolQQShow.Click += new System.EventHandler(this.tuopan_DoubleClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 6);
            // 
            // toolExit
            // 
            this.toolExit.AutoSize = false;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(119, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // MenuState
            // 
            this.MenuState.Arrow = System.Drawing.Color.Black;
            this.MenuState.AutoSize = false;
            this.MenuState.Back = System.Drawing.Color.White;
            this.MenuState.BackRadius = 4;
            this.MenuState.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.MenuState.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Fore = System.Drawing.Color.Black;
            this.MenuState.HoverFore = System.Drawing.Color.White;
            this.MenuState.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.MenuState.ItemAnamorphosis = false;
            this.MenuState.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemBorderShow = false;
            this.MenuState.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemRadius = 4;
            this.MenuState.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemImonline,
            this.ItemQme,
            this.toolStripMenuItem1,
            this.ItemAway,
            this.ItemBusy,
            this.ItemMute,
            this.toolStripMenuItem2,
            this.ItemInVisble});
            this.MenuState.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Name = "MenuState";
            this.MenuState.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.MenuState.Size = new System.Drawing.Size(106, 147);
            this.MenuState.SkinAllColor = true;
            this.MenuState.TitleAnamorphosis = false;
            this.MenuState.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.MenuState.TitleRadius = 4;
            this.MenuState.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // ItemImonline
            // 
            this.ItemImonline.AutoSize = false;
            this.ItemImonline.Image = global::CC2013.Properties.Resources.imonline__2_;
            this.ItemImonline.Name = "ItemImonline";
            this.ItemImonline.Size = new System.Drawing.Size(105, 22);
            this.ItemImonline.Tag = "2";
            this.ItemImonline.Text = "我在线上";
            this.ItemImonline.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemImonline.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemQme
            // 
            this.ItemQme.AutoSize = false;
            this.ItemQme.Image = global::CC2013.Properties.Resources.Qme__2_;
            this.ItemQme.Name = "ItemQme";
            this.ItemQme.Size = new System.Drawing.Size(105, 22);
            this.ItemQme.Tag = "1";
            this.ItemQme.Text = "Q我把";
            this.ItemQme.ToolTipText = "表示希望好友主动联系您。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：自动弹出会话窗口\r\n";
            this.ItemQme.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemAway
            // 
            this.ItemAway.AutoSize = false;
            this.ItemAway.Image = global::CC2013.Properties.Resources.away__2_;
            this.ItemAway.Name = "ItemAway";
            this.ItemAway.Size = new System.Drawing.Size(105, 22);
            this.ItemAway.Tag = "3";
            this.ItemAway.Text = "离开";
            this.ItemAway.ToolTipText = "表示离开，暂无法处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemAway.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemBusy
            // 
            this.ItemBusy.AutoSize = false;
            this.ItemBusy.Image = global::CC2013.Properties.Resources.busy__2_;
            this.ItemBusy.Name = "ItemBusy";
            this.ItemBusy.Size = new System.Drawing.Size(105, 22);
            this.ItemBusy.Tag = "4";
            this.ItemBusy.Text = "忙碌";
            this.ItemBusy.ToolTipText = "表示忙碌，不会及时处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏显示气泡\r\n";
            this.ItemBusy.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemMute
            // 
            this.ItemMute.AutoSize = false;
            this.ItemMute.Image = global::CC2013.Properties.Resources.mute__2_;
            this.ItemMute.Name = "ItemMute";
            this.ItemMute.Size = new System.Drawing.Size(105, 22);
            this.ItemMute.Tag = "5";
            this.ItemMute.Text = "请勿打扰";
            this.ItemMute.ToolTipText = "表示不想被打扰。\r\n声音：关闭\r\n消息提醒框：关闭\r\n会话消息：任务栏显示气泡\r\n\r\n";
            this.ItemMute.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemInVisble
            // 
            this.ItemInVisble.AutoSize = false;
            this.ItemInVisble.Image = global::CC2013.Properties.Resources.invisible__2_;
            this.ItemInVisble.Name = "ItemInVisble";
            this.ItemInVisble.Size = new System.Drawing.Size(105, 22);
            this.ItemInVisble.Tag = "6";
            this.ItemInVisble.Text = "隐身";
            this.ItemInVisble.ToolTipText = "表示好友看到您是离线的。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemInVisble.Click += new System.EventHandler(this.Item_Click);
            // 
            // MenuId
            // 
            this.MenuId.Arrow = System.Drawing.Color.Black;
            this.MenuId.AutoSize = false;
            this.MenuId.Back = System.Drawing.Color.White;
            this.MenuId.BackColor = System.Drawing.Color.White;
            this.MenuId.BackRadius = 4;
            this.MenuId.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.MenuId.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(209)))));
            this.MenuId.Fore = System.Drawing.Color.Black;
            this.MenuId.HoverFore = System.Drawing.Color.White;
            this.MenuId.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.MenuId.ItemAnamorphosis = false;
            this.MenuId.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemBorderShow = false;
            this.MenuId.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuId.ItemRadius = 4;
            this.MenuId.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuId.Name = "MenuId";
            this.MenuId.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.Size = new System.Drawing.Size(183, 4);
            this.MenuId.SkinAllColor = true;
            this.MenuId.TitleAnamorphosis = false;
            this.MenuId.TitleColor = System.Drawing.Color.White;
            this.MenuId.TitleRadius = 4;
            this.MenuId.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuId.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.MenuId_Closing);
            // 
            // chkMima
            // 
            this.chkMima.AutoSize = true;
            this.chkMima.BackColor = System.Drawing.Color.Transparent;
            this.chkMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkMima.DefaultCheckButtonWidth = 15;
            this.chkMima.DownBack = global::CC2013.Properties.Resources.checkbox_pushed;
            this.chkMima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMima.ForeColor = System.Drawing.Color.Black;
            this.chkMima.LightEffect = false;
            this.chkMima.Location = new System.Drawing.Point(112, 208);
            this.chkMima.MouseBack = global::CC2013.Properties.Resources.checkbox_hightlight;
            this.chkMima.Name = "chkMima";
            this.chkMima.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkMima.NormlBack")));
            this.chkMima.SelectedDownBack = global::CC2013.Properties.Resources.checkbox_tick_pushed;
            this.chkMima.SelectedMouseBack = global::CC2013.Properties.Resources.checkbox_tick_highlight;
            this.chkMima.SelectedNormlBack = global::CC2013.Properties.Resources.checkbox_tick_normal;
            this.chkMima.Size = new System.Drawing.Size(75, 21);
            this.chkMima.TabIndex = 3;
            this.chkMima.Text = "记住密码";
            this.chkMima.UseVisualStyleBackColor = false;
            this.chkMima.CheckedChanged += new System.EventHandler(this.chkMima_CheckedChanged);
            // 
            // timShow
            // 
            this.timShow.Interval = 500;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // imgLoadding
            // 
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(1, 242);
            this.imgLoadding.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(377, 2);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 18;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // btnMbShow
            // 
            this.btnMbShow.BackColor = System.Drawing.Color.Transparent;
            this.btnMbShow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnMbShow.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMbShow.DownBack = null;
            this.btnMbShow.ForeColorSuit = true;
            this.btnMbShow.Location = new System.Drawing.Point(128, 47);
            this.btnMbShow.MouseBack = null;
            this.btnMbShow.Name = "btnMbShow";
            this.btnMbShow.NormlBack = null;
            this.btnMbShow.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnMbShow.Size = new System.Drawing.Size(124, 48);
            this.btnMbShow.TabIndex = 19;
            this.btnMbShow.Text = "弹出MessageBox";
            this.btnMbShow.UseVisualStyleBackColor = false;
            this.btnMbShow.Visible = false;
            this.btnMbShow.Click += new System.EventHandler(this.btnMbShow_Click);
            // 
            // btnDl
            // 
            this.btnDl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDl.BackColor = System.Drawing.Color.Transparent;
            this.btnDl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDl.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnDl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDl.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDl.DownBack")));
            this.btnDl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDl.ForeColor = System.Drawing.Color.Black;
            this.btnDl.Location = new System.Drawing.Point(109, 247);
            this.btnDl.Margin = new System.Windows.Forms.Padding(0);
            this.btnDl.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDl.MouseBack")));
            this.btnDl.Name = "btnDl";
            this.btnDl.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDl.NormlBack")));
            this.btnDl.Palace = true;
            this.btnDl.Size = new System.Drawing.Size(162, 38);
            this.btnDl.TabIndex = 8;
            this.btnDl.Text = "登        录";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.Icon = null;
            this.txtId.IconIsButton = false;
            this.txtId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.Location = new System.Drawing.Point(112, 139);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtId.MouseBack = null;
            this.txtId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtId.Name = "txtId";
            this.txtId.NormlBack = null;
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtId.Size = new System.Drawing.Size(185, 28);
            // 
            // txtId.BaseText
            // 
            this.txtId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtId.SkinTxt.Name = "BaseText";
            this.txtId.SkinTxt.Size = new System.Drawing.Size(152, 18);
            this.txtId.SkinTxt.TabIndex = 0;
            this.txtId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.SkinTxt.WaterText = "QQ号码/手机/邮箱";
            this.txtId.TabIndex = 32;
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.White;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnId.DownBack = global::CC2013.Properties.Resources.login_inputbtn_down;
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.Location = new System.Drawing.Point(273, 141);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = global::CC2013.Properties.Resources.login_inputbtn_highlight;
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = global::CC2013.Properties.Resources.login_inputbtn_normal;
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 5;
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnId_MouseDown);
            this.btnId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.btnId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // pwdErro
            // 
            this.pwdErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pwdErro.Location = new System.Drawing.Point(375, 30);
            this.pwdErro.Name = "pwdErro";
            this.pwdErro.Size = new System.Drawing.Size(378, 260);
            this.pwdErro.TabIndex = 34;
            this.pwdErro.Visible = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Back = global::CC2013.Properties.Resources.night;
            this.BackPalace = global::CC2013.Properties.Resources.BackPalace2;
            this.BackShade = false;
            this.BorderPalace = global::CC2013.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 292);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::CC2013.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::CC2013.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::CC2013.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(-2, -1);
            this.Controls.Add(this.pwdErro);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.imgLoadding);
            this.Controls.Add(this.chkMima);
            this.Controls.Add(this.chkZdLogin);
            this.Controls.Add(this.btnMbShow);
            this.Controls.Add(this.btnMima);
            this.Controls.Add(this.btnZc);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.btnDuoId);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnSw);
            this.Controls.Add(this.txtId);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::CC2013.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::CC2013.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::CC2013.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::CC2013.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::CC2013.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::CC2013.Properties.Resources.btn_mini_normal;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "FrmLogin";
            this.RestoreDownBack = global::CC2013.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::CC2013.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::CC2013.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(287, -1, 28, 20);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(287, -1);
            cmSysButton1.Name = "SysTool";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.SysButtonDown = global::CC2013.Properties.Resources.btn_set_press;
            cmSysButton1.SysButtonMouse = global::CC2013.Properties.Resources.btn_set_hover;
            cmSysButton1.SysButtonNorml = global::CC2013.Properties.Resources.btn_set_normal;
            cmSysButton1.ToolTip = "设置";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1});
            this.Text = "CC2013";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.txtPwd.ResumeLayout(false);
            this.txtPwd.PerformLayout();
            this.pnlTx.ResumeLayout(false);
            this.pnlImgTx.ResumeLayout(false);
            this.QQMenu.ResumeLayout(false);
            this.MenuState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            this.txtId.ResumeLayout(false);
            this.txtId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnDuoId;
        private CCWin.SkinControl.SkinButton btnSw;
        private CCWin.SkinControl.SkinCheckBox chkZdLogin;
        private CCWin.SkinControl.SkinButton btnMima;
        private CCWin.SkinControl.SkinButton btnZc;
        private CCWin.SkinControl.SkinTextBox txtPwd;
        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinButton btnState;
        private System.Windows.Forms.ToolTip toolShow;
        public System.Windows.Forms.NotifyIcon tuopan;
        private CCWin.SkinControl.SkinContextMenuStrip MenuState;
        private System.Windows.Forms.ToolStripMenuItem ItemImonline;
        private System.Windows.Forms.ToolStripMenuItem ItemQme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemAway;
        private System.Windows.Forms.ToolStripMenuItem ItemBusy;
        private System.Windows.Forms.ToolStripMenuItem ItemMute;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ItemInVisble;
        private CCWin.SkinControl.SkinContextMenuStrip MenuId;
        private CCWin.SkinControl.SkinCheckBox chkMima;
        private System.Windows.Forms.Timer timShow;
        private CCWin.SkinControl.SkinContextMenuStrip QQMenu;
        private System.Windows.Forms.ToolStripMenuItem toolQQShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.PictureBox imgLoadding;
        private CCWin.SkinControl.SkinButton btnMbShow;
        private CCWin.SkinControl.SkinButton btnDl;
        private CCWin.SkinControl.SkinTextBox txtId;
        private CCWin.SkinControl.SkinButton btnId;
        private CC2013.PwdErro pwdErro;
    }
}