namespace WeiChat
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FriendList = new CCWin.SkinControl.ChatListBox();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.lblGroupName = new CCWin.SkinControl.SkinLabel();
            this.lblChatQm = new CCWin.SkinControl.SkinLabel();
            this.txtRMsg = new CCWin.SkinControl.RtfRichTextBox();
            this.TxTMsg = new CCWin.SkinControl.RtfRichTextBox();
            this.btnSend = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.btnSendMenu = new CCWin.SkinControl.SkinButton();
            this.skToolMenu = new CCWin.SkinControl.SkinToolStrip();
            this.toolCountenance = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.skToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FriendList
            // 
            this.FriendList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FriendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FriendList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendList.ForeColor = System.Drawing.Color.Black;
            this.FriendList.FriendsMobile = true;
            this.FriendList.IconSizeMode = CCWin.SkinControl.ChatListItemIcon.Small;
            this.FriendList.ListSubItemMenu = null;
            this.FriendList.Location = new System.Drawing.Point(449, 219);
            this.FriendList.Margin = new System.Windows.Forms.Padding(0);
            this.FriendList.Name = "FriendList";
            this.FriendList.SelectSubItem = null;
            this.FriendList.Size = new System.Drawing.Size(252, 218);
            this.FriendList.SubItemMenu = null;
            this.FriendList.TabIndex = 148;
            this.FriendList.VipFontColor = System.Drawing.Color.Empty;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImgTx.BackgroundImage")));
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(14, 8);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 4;
            this.pnlImgTx.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pnlImgTx.Size = new System.Drawing.Size(40, 40);
            this.pnlImgTx.TabIndex = 7;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.BorderColor = System.Drawing.Color.Black;
            this.lblGroupName.BorderSize = 4;
            this.lblGroupName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGroupName.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lblGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblGroupName.ForeColorSuit = true;
            this.lblGroupName.Location = new System.Drawing.Point(57, 15);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(126, 25);
            this.lblGroupName.TabIndex = 141;
            this.lblGroupName.Text = "微信群发助手";
            // 
            // lblChatQm
            // 
            this.lblChatQm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChatQm.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Anamorphosis;
            this.lblChatQm.AutoSize = true;
            this.lblChatQm.BackColor = System.Drawing.Color.Transparent;
            this.lblChatQm.BorderColor = System.Drawing.Color.White;
            this.lblChatQm.BorderSize = 4;
            this.lblChatQm.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblChatQm.ForeColor = System.Drawing.Color.Black;
            this.lblChatQm.ForeColorSuit = true;
            this.lblChatQm.Location = new System.Drawing.Point(177, 15);
            this.lblChatQm.Name = "lblChatQm";
            this.lblChatQm.Size = new System.Drawing.Size(31, 17);
            this.lblChatQm.TabIndex = 142;
            this.lblChatQm.Text = "v1.0";
            // 
            // txtRMsg
            // 
            this.txtRMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRMsg.BackColor = System.Drawing.Color.White;
            this.txtRMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRMsg.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtRMsg.Location = new System.Drawing.Point(4, 84);
            this.txtRMsg.Margin = new System.Windows.Forms.Padding(0);
            this.txtRMsg.Name = "txtRMsg";
            this.txtRMsg.ReadOnly = true;
            this.txtRMsg.Size = new System.Drawing.Size(434, 226);
            this.txtRMsg.TabIndex = 143;
            this.txtRMsg.Text = "系统操作日志:";
            this.txtRMsg.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // TxTMsg
            // 
            this.TxTMsg.AcceptsTab = true;
            this.TxTMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxTMsg.AutoWordSelection = true;
            this.TxTMsg.BackColor = System.Drawing.Color.White;
            this.TxTMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxTMsg.DetectUrls = false;
            this.TxTMsg.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TxTMsg.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.TxTMsg.Location = new System.Drawing.Point(4, 343);
            this.TxTMsg.Margin = new System.Windows.Forms.Padding(0);
            this.TxTMsg.Name = "TxTMsg";
            this.TxTMsg.Size = new System.Drawing.Size(434, 94);
            this.TxTMsg.TabIndex = 144;
            this.TxTMsg.Text = "";
            this.TxTMsg.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnSend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSend.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSend.DownBack")));
            this.btnSend.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(352, 439);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSend.MouseBack")));
            this.btnSend.Name = "btnSend";
            this.btnSend.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSend.NormlBack")));
            this.btnSend.Size = new System.Drawing.Size(61, 24);
            this.btnSend.TabIndex = 146;
            this.btnSend.Text = "发送(&S)";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "更新日志:",
        "1.支持表情群发;",
        "2.支持截图群发",
        "3.支持语音文件发送",
        "仅支持以上接口,Ui正在修改"};
            this.skinTextBox1.Location = new System.Drawing.Point(449, 84);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(252, 130);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(242, 120);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "更新日志:\r\n1.支持表情群发;\r\n2.支持截图群发\r\n3.支持语音文件发送\r\n仅支持以上接口,Ui正在修改";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 147;
            this.skinTextBox1.Text = "更新日志:\r\n1.支持表情群发;\r\n2.支持截图群发\r\n3.支持语音文件发送\r\n仅支持以上接口,Ui正在修改";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.White;
            this.skinToolStrip2.Back = System.Drawing.Color.White;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemNorml = null;
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseItemRadius = 2;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BindTabControl = null;
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ItemAnamorphosis = false;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = false;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 1;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Location = new System.Drawing.Point(14, 50);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Size = new System.Drawing.Size(102, 25);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 149;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnSendMenu
            // 
            this.btnSendMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnSendMenu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSendMenu.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSendMenu.DownBack")));
            this.btnSendMenu.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSendMenu.Location = new System.Drawing.Point(413, 439);
            this.btnSendMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendMenu.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSendMenu.MouseBack")));
            this.btnSendMenu.Name = "btnSendMenu";
            this.btnSendMenu.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSendMenu.NormlBack")));
            this.btnSendMenu.Size = new System.Drawing.Size(20, 24);
            this.btnSendMenu.TabIndex = 150;
            this.btnSendMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMenu.UseVisualStyleBackColor = false;
            // 
            // skToolMenu
            // 
            this.skToolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skToolMenu.Arrow = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skToolMenu.AutoSize = false;
            this.skToolMenu.Back = System.Drawing.Color.White;
            this.skToolMenu.BackColor = System.Drawing.Color.Transparent;
            this.skToolMenu.BackRadius = 4;
            this.skToolMenu.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skToolMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skToolMenu.BaseFore = System.Drawing.Color.Black;
            this.skToolMenu.BaseForeAnamorphosis = false;
            this.skToolMenu.BaseForeAnamorphosisBorder = 4;
            this.skToolMenu.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skToolMenu.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skToolMenu.BaseHoverFore = System.Drawing.Color.Black;
            this.skToolMenu.BaseItemAnamorphosis = true;
            this.skToolMenu.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.skToolMenu.BaseItemBorderShow = true;
            this.skToolMenu.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skToolMenu.BaseItemDown")));
            this.skToolMenu.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skToolMenu.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skToolMenu.BaseItemMouse")));
            this.skToolMenu.BaseItemNorml = null;
            this.skToolMenu.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skToolMenu.BaseItemRadius = 2;
            this.skToolMenu.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skToolMenu.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(195)))), ((int)(((byte)(204)))));
            this.skToolMenu.BindTabControl = null;
            this.skToolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.skToolMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skToolMenu.Fore = System.Drawing.Color.Black;
            this.skToolMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skToolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skToolMenu.HoverFore = System.Drawing.Color.White;
            this.skToolMenu.ItemAnamorphosis = false;
            this.skToolMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemBorderShow = false;
            this.skToolMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemRadius = 3;
            this.skToolMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCountenance,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton7,
            this.toolStripLabel1,
            this.toolStripButton4});
            this.skToolMenu.Location = new System.Drawing.Point(5, 316);
            this.skToolMenu.Name = "skToolMenu";
            this.skToolMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skToolMenu.Size = new System.Drawing.Size(433, 27);
            this.skToolMenu.SkinAllColor = true;
            this.skToolMenu.TabIndex = 151;
            this.skToolMenu.Text = "skinToolStrip1";
            this.skToolMenu.TitleAnamorphosis = false;
            this.skToolMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skToolMenu.TitleRadius = 4;
            this.skToolMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolCountenance
            // 
            this.toolCountenance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCountenance.Image = global::Wechat.Properties.Resources.aio_quickbar_face;
            this.toolCountenance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolCountenance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCountenance.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolCountenance.Name = "toolCountenance";
            this.toolCountenance.Size = new System.Drawing.Size(24, 24);
            this.toolCountenance.Text = "toolStripButton2";
            this.toolCountenance.ToolTipText = "选择表情";
            this.toolCountenance.Click += new System.EventHandler(this.toolCountenance_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Wechat.Properties.Resources.aio_quickbar_sendpic;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton7";
            this.toolStripButton3.ToolTipText = "发送图片";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(5, 24);
            this.toolStripLabel3.Text = "toolStripButton9";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "发送语音";
            this.toolStripButton7.ToolTipText = "语音";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(5, 24);
            this.toolStripLabel1.Text = "toolStripButton9";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton4.Text = "截图";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::Wechat.Properties.Resources.main_1;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderPalace = global::Wechat.Properties.Resources.BackPalace;
            this.ClientSize = new System.Drawing.Size(700, 471);
            this.Controls.Add(this.skToolMenu);
            this.Controls.Add(this.btnSendMenu);
            this.Controls.Add(this.skinToolStrip2);
            this.Controls.Add(this.FriendList);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.TxTMsg);
            this.Controls.Add(this.txtRMsg);
            this.Controls.Add(this.lblChatQm);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.pnlImgTx);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Main_Load);
            this.skToolMenu.ResumeLayout(false);
            this.skToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinLabel lblGroupName;
        private CCWin.SkinControl.SkinLabel lblChatQm;
        private CCWin.SkinControl.RtfRichTextBox txtRMsg;
        public CCWin.SkinControl.RtfRichTextBox TxTMsg;
        private CCWin.SkinControl.SkinButton btnSend;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.ChatListBox FriendList;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private CCWin.SkinControl.SkinButton btnSendMenu;
        private CCWin.SkinControl.SkinToolStrip skToolMenu;
        private System.Windows.Forms.ToolStripButton toolCountenance;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

