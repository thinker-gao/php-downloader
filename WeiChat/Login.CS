using CCWin;
using CCWin.SkinClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WeiChat
{
    public partial class Login : CCSkinMain
    {
        static Form MainForm;
        static Thread GoTask;
        static System.Windows.Forms.Timer GoTimer = new System.Windows.Forms.Timer();
        static bool exitFlag = false;
        public Login()
        {
            InitializeComponent();
            MainForm = new Main();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//跨线程操作控件
            GetQrocode();
            MessageBoxEx.Show("欢迎使用微信群发工具", "免费版", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoTask = new Thread(CheckLogin);
            GoTask.Start();
        }

        private void btnDuoId_Click(object sender, EventArgs e)
        {
            Process.Start(WeichatTool.Authurl);
        }

        private void GetQrcode_Click(object sender, EventArgs e)
        {
            GetQrocode();
            
        }

        private void GetMoreQrcode_Click(object sender, EventArgs e)
        {
            GetQrocode();
        }

        private void GetQrocode()
        {
            Image WeichatQrcode = WeichatTool.QrcodeStream();
            Qrcode.BackgroundImage = WeichatQrcode;
        }

        private void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
        {
            
            bool isget = WeichatTool.Getticket();
            if (isget)
            {
                isget = WeichatTool.GetUserinfo();
                if (isget) {
                    GoTimer.Stop();
                    GoTimer.Enabled = false;
                    Hide();
                    MainForm.Show();
                }
            }
            
        }


        private void CheckLogin() {
            GoTimer.Tick += new EventHandler(TimerEventProcessor);
            GoTimer.Interval = 1000;
            GoTimer.Enabled = true;
            GoTimer.Start();
            while (exitFlag == false)
            {
                Application.DoEvents();
            }
        }

    }
}
