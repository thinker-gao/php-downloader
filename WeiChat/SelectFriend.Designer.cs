namespace Wechat
{
    partial class SelectFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFriend));
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.SelectOk = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.HorizontalScrollbar = true;
            this.checkedListBox.Location = new System.Drawing.Point(7, 36);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(270, 192);
            this.checkedListBox.TabIndex = 1;
            // 
            // SelectOk
            // 
            this.SelectOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectOk.BackColor = System.Drawing.Color.Transparent;
            this.SelectOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.SelectOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SelectOk.DownBack = ((System.Drawing.Image)(resources.GetObject("SelectOk.DownBack")));
            this.SelectOk.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.SelectOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectOk.Location = new System.Drawing.Point(76, 231);
            this.SelectOk.MouseBack = ((System.Drawing.Image)(resources.GetObject("SelectOk.MouseBack")));
            this.SelectOk.Name = "SelectOk";
            this.SelectOk.NormlBack = ((System.Drawing.Image)(resources.GetObject("SelectOk.NormlBack")));
            this.SelectOk.Size = new System.Drawing.Size(128, 24);
            this.SelectOk.TabIndex = 136;
            this.SelectOk.Text = "确认选择";
            this.SelectOk.UseVisualStyleBackColor = false;
            this.SelectOk.Click += new System.EventHandler(this.SelectOk_Click);
            // 
            // SelectFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.White;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SelectOk);
            this.Controls.Add(this.checkedListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MdiBackColor = System.Drawing.Color.White;
            this.Name = "SelectFriend";
            this.ShadowColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择好友";
            this.Load += new System.EventHandler(this.SelectFriend_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private CCWin.SkinControl.SkinButton SelectOk;
    }
}