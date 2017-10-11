namespace WeiChat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.GetQrcode = new CCWin.SkinControl.SkinButton();
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.GetMoreQrcode = new CCWin.SkinControl.SkinButton();
            this.btnDuoId = new CCWin.SkinControl.SkinButton();
            this.Qrcode = new CCWin.SkinControl.SkinPanel();
            this.btnState = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            this.Qrcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetQrcode
            // 
            this.GetQrcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetQrcode.BackColor = System.Drawing.Color.Transparent;
            this.GetQrcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GetQrcode.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.GetQrcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.GetQrcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GetQrcode.DownBack = ((System.Drawing.Image)(resources.GetObject("GetQrcode.DownBack")));
            this.GetQrcode.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.GetQrcode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.GetQrcode.ForeColor = System.Drawing.Color.Black;
            this.GetQrcode.Location = new System.Drawing.Point(102, 250);
            this.GetQrcode.Margin = new System.Windows.Forms.Padding(0);
            this.GetQrcode.MouseBack = ((System.Drawing.Image)(resources.GetObject("GetQrcode.MouseBack")));
            this.GetQrcode.Name = "GetQrcode";
            this.GetQrcode.NormlBack = ((System.Drawing.Image)(resources.GetObject("GetQrcode.NormlBack")));
            this.GetQrcode.Palace = true;
            this.GetQrcode.Size = new System.Drawing.Size(162, 38);
            this.GetQrcode.TabIndex = 9;
            this.GetQrcode.Text = "更新二维码";
            this.GetQrcode.UseVisualStyleBackColor = false;
            this.GetQrcode.Click += new System.EventHandler(this.GetQrcode_Click);
            // 
            // imgLoadding
            // 
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(4, 237);
            this.imgLoadding.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(377, 2);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 19;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // GetMoreQrcode
            // 
            this.GetMoreQrcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetMoreQrcode.BackColor = System.Drawing.Color.Transparent;
            this.GetMoreQrcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.GetMoreQrcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GetMoreQrcode.DownBack = ((System.Drawing.Image)(resources.GetObject("GetMoreQrcode.DownBack")));
            this.GetMoreQrcode.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.GetMoreQrcode.Location = new System.Drawing.Point(323, 251);
            this.GetMoreQrcode.Margin = new System.Windows.Forms.Padding(0);
            this.GetMoreQrcode.MouseBack = ((System.Drawing.Image)(resources.GetObject("GetMoreQrcode.MouseBack")));
            this.GetMoreQrcode.Name = "GetMoreQrcode";
            this.GetMoreQrcode.NormlBack = ((System.Drawing.Image)(resources.GetObject("GetMoreQrcode.NormlBack")));
            this.GetMoreQrcode.Size = new System.Drawing.Size(38, 38);
            this.GetMoreQrcode.TabIndex = 20;
            this.GetMoreQrcode.UseVisualStyleBackColor = false;
            this.GetMoreQrcode.Click += new System.EventHandler(this.GetMoreQrcode_Click);
            // 
            // btnDuoId
            // 
            this.btnDuoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuoId.BackColor = System.Drawing.Color.Transparent;
            this.btnDuoId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDuoId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDuoId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.DownBack")));
            this.btnDuoId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDuoId.Location = new System.Drawing.Point(19, 258);
            this.btnDuoId.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuoId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.MouseBack")));
            this.btnDuoId.Name = "btnDuoId";
            this.btnDuoId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDuoId.NormlBack")));
            this.btnDuoId.Size = new System.Drawing.Size(25, 25);
            this.btnDuoId.TabIndex = 21;
            this.btnDuoId.UseVisualStyleBackColor = false;
            this.btnDuoId.Click += new System.EventHandler(this.btnDuoId_Click);
            // 
            // Qrcode
            // 
            this.Qrcode.BackColor = System.Drawing.Color.Transparent;
            this.Qrcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Qrcode.BackgroundImage")));
            this.Qrcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Qrcode.Controls.Add(this.btnState);
            this.Qrcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Qrcode.DownBack = null;
            this.Qrcode.Location = new System.Drawing.Point(130, 97);
            this.Qrcode.Margin = new System.Windows.Forms.Padding(0);
            this.Qrcode.MouseBack = null;
            this.Qrcode.Name = "Qrcode";
            this.Qrcode.NormlBack = null;
            this.Qrcode.Radius = 4;
            this.Qrcode.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Qrcode.Size = new System.Drawing.Size(105, 105);
            this.Qrcode.TabIndex = 22;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnState.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = null;
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.ImageSize = new System.Drawing.Size(11, 11);
            this.btnState.Location = new System.Drawing.Point(67, 67);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = null;
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Size = new System.Drawing.Size(18, 18);
            this.btnState.TabIndex = 11;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Back = global::Wechat.Properties.Resources.night;
            this.BackPalace = global::Wechat.Properties.Resources.BackPalace2;
            this.BackShade = false;
            this.BorderPalace = global::Wechat.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 292);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::Wechat.Properties.Resources.btn_close_down1;
            this.CloseMouseBack = global::Wechat.Properties.Resources.btn_close_highlight1;
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(-2, -1);
            this.Controls.Add(this.Qrcode);
            this.Controls.Add(this.btnDuoId);
            this.Controls.Add(this.GetMoreQrcode);
            this.Controls.Add(this.imgLoadding);
            this.Controls.Add(this.GetQrcode);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::Wechat.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::Wechat.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::Wechat.Properties.Resources.btn_mini_normal1;
            this.Name = "Login";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            this.Qrcode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton GetQrcode;
        private System.Windows.Forms.PictureBox imgLoadding;
        private CCWin.SkinControl.SkinButton GetMoreQrcode;
        private CCWin.SkinControl.SkinButton btnDuoId;
        private CCWin.SkinControl.SkinPanel Qrcode;
        private CCWin.SkinControl.SkinButton btnState;
    }
}