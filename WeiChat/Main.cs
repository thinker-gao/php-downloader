using CCWin;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Wechat;

namespace WeiChat
{
    public partial class Main : CCSkinMain
    {

        private static Thread GoTask;


        private Form SelectFriendForm = new SelectFriend();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;//跨线程操作控件
            GoTask = new Thread(Init);
            GoTask.Start();
        }


        private void Init() {

            bool init = WeichatTool.InitWeicaht();
            WeichatTool.Friendlist = WeichatTool.Memberlist();
            var Friendlist = JsonConvert.DeserializeObject<dynamic>(WeichatTool.Friendlist);

            //创建好友列表容器
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            //设置容器
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 202, 53);
            chatListItem1.IsOpen = true;
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.FriendList;
            chatListItem1.Tag = null;
            chatListItem1.Text = "好友列表";
            chatListItem1.TwinkleSubItemNumber = 0;
            //填充好友列表
            foreach (var rows in Friendlist.MemberList)
            {
                CCWin.SkinControl.ChatListSubItem chatListSubItemNum = new CCWin.SkinControl.ChatListSubItem();
                chatListSubItemNum.Bounds = new System.Drawing.Rectangle(0, 27, 202, 27);
                chatListSubItemNum.DisplayName = rows.RemarkName;
                chatListSubItemNum.HeadRect = new System.Drawing.Rectangle(5, 30, 20, 20);
               //chatListSubItemNum.HeadImage = WeichatTool.CreateHttpimg("https://wx.qq.com" + rows.HeadImgUrl);
                chatListSubItemNum.ID = ((uint)(0u));
                chatListSubItemNum.NicName = rows.NickName;
                chatListSubItemNum.OwnerListItem = chatListItem1;
                chatListSubItemNum.PersonalMsg =rows.Signature; ;
                chatListItem1.SubItems.AddRange(new CCWin.SkinControl.ChatListSubItem[] {
                chatListSubItemNum});
                this.FriendList.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1});
   
            }
        }
 

        private void btnSend_Click(object sender, EventArgs e)
        {
            WeichatTool.TextMessage = TxTMsg.Text;
            Form SelectFriendForm = new SelectFriend();
            SelectFriendForm.Show();
        }

        private void toolCountenance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待!");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待!");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待!");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待!");
        }
    }
}
