using CCWin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeiChat;
using System.Web;

namespace Wechat
{
    public partial class SelectFriend : Skin_DevExpress
    {
        public SelectFriend()
        {
            InitializeComponent();
        }

        private void SelectFriend_Load(object sender, EventArgs e)
        {
            var Friendlist = JsonConvert.DeserializeObject<dynamic>(WeichatTool.Friendlist);
            foreach (var rows in Friendlist.MemberList)
            {
                string AddText = "";
                if (rows.RemarkName != "")
                {
                    AddText = rows.RemarkName + "," + rows.UserName;
                }
                else
                {
                    
                    AddText = rows.NickName + "," + rows.UserName;
                }
                checkedListBox.Items.Add(AddText);
            }
        }

        private void SelectOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    string[] ToUserInfo = checkedListBox.GetItemText(checkedListBox.Items[i]).Split(',');
                    string ToUser = ToUserInfo[1];
                    string TxtMsg = WeichatTool.TextMessage;
                    WeichatTool.SendTextMessage(TxtMsg, ToUser);
                }
            }
            MessageBoxEx.Show("全部信息发送成功!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
