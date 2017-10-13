using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WeiChat
{
    class WeichatTool
    {
        public  static string Authurl = "https://user.qzone.qq.com/392223903/infocenter";
        private static string uuid;//微信请求的UUID，
        private static string HttpCookie;//微信Http请求携带的Cookie数据
        private static string ticket;//微信请求的ticket
        private static string skey;//微信请求的skey
        private static string wxsid;//微信请求的wxsid
        private static string wxusername;//微信请求的用户名
        private static string wxuin;//微信请求的wxuin
        private static string Deviceid;//微信请求的DeviceID
        private static string passticket;//微信请求的passticket
        public  static string Friendlist;//好友列表Html
        public static string  TextMessage;//消息文本内容


        private static string GetUuidUrl = "https://login.wx.qq.com/jslogin?appid=wx782c26e4c19acffb&redirect_uri=https%3A%2F%2Fwx.qq.com%2Fcgi-bin%2Fmmwebwx-bin%2Fwebwxnewloginpage&fun=new&lang=zh_CN&_=";//生成UUid Api
        private static string GetQrcodeUrl = "https://login.weixin.qq.com/qrcode/";//生成二维码的Api
        private static string CheckQrcodeUrl = "https://login.wx.qq.com/cgi-bin/mmwebwx-bin/login?loginicon=true&uuid=";//检测二维码扫描结果Api
        private static string GetUserinfoUrl = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxnewloginpage?lang=zh_CN&ticket=";//微信initApi
        private static string initUrl = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxinit?";
        private static string ContactUrl = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgetcontact?lang=zh_CN";//好友列表Api
        private static string SendMessageUrl = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsendmsg?lang=zh_CN&pass_ticket=";//发送消息Api
        private static string UploadFileUrl = "https://file.wx.qq.com/cgi-bin/mmwebwx-bin/webwxuploadmedia?f=json";//文件上传Api


        //(1)生成微信需要的UUid.
        public static string Uuid()
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = GetUuidUrl + GetTime(2),
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html.Trim();
            //HttpCookie = result.Cookie;
            //System.IO.File.WriteAllText(@"D:\INDEX.txt", result.Cookie);
            string[] Temphtml = html.Split(';')[1].Split('"'); ;
            uuid = Temphtml[1];
            return uuid;
        }

        //(2)生成二维码并且将远程图片转Stream处理.
        public static Image QrcodeStream()
        {
            string qrcodeurl = GetQrcodeUrl + Uuid();
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = qrcodeurl,
                Cookie = HttpCookie,
                ResultType = ResultType.Byte
            };
            HttpResult result = http.GetHtml(item);
            MemoryStream ms = new MemoryStream(result.ResultByte);
            Image outputImg = Image.FromStream(ms);
            return outputImg;
        }

        //(3)轮训检测二维码是否扫描登陆成功.
        public static bool Getticket()
        {
            Random ran = new Random();
            CheckQrcodeUrl += uuid + "&tip=1&r=" + ran.Next(1000000, 9999999) + "&_=" + GetTime(2);
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = CheckQrcodeUrl,
                Cookie = HttpCookie,
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html.Trim();
            int startcharnum = html.IndexOf("ticket");
            if (startcharnum > 0)
            {
                Match Ticket = Regex.Match(html, "ticket=([^<]*)@qrticket", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                ticket = Ticket.Groups[1].Value;
                return true;
            }
            else
            {
                return false;
            }
        }

        //(4)通过3中的ticket获取skey,wxsid,wxuin,pass_ticket
        public static bool GetUserinfo()
        {
            GetUserinfoUrl += ticket + "@qrticket_0&uuid=" + uuid + "&lang=zh_CN&scan=" + GetTime(2) + "&fun=new&version=v";
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = GetUserinfoUrl,
                Cookie = HttpCookie,
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html.Trim();
            System.IO.File.WriteAllText(@"D:\1.txt", HttpCookie);
            HttpCookie = HttpCookieHelper.GetSmallCookie(result.Cookie);//updateCookie(HttpCookieHelper.GetSmallCookie(HttpCookie), HttpCookieHelper.GetSmallCookie(result.Cookie));
            
            int startcharnum = html.IndexOf("wxsid");
            if (startcharnum > 0)
            {
                string[] pattern = { "<skey>([^<]*)</skey>", "<wxsid>([^<]*)</wxsid>", "<wxuin>([^<]*)</wxuin>", "<pass_ticket>([^<]*)</pass_ticket>" };
                for (int i = 0; i < pattern.Length; i++)
                {
                    Match Parms = Regex.Match(html, pattern[i], RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    string TempString = Parms.Groups[1].Value;
                    switch (i)
                    {
                        case 0:
                            skey = TempString;
                            break;
                        case 1:
                            wxsid = TempString;
                            break;
                        case 2:
                            wxuin = TempString;
                            break;
                        case 3:
                            passticket = TempString;
                            break;
                        default:
                            break;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //5.初始化微信inint.
        public static bool InitWeicaht()
        {

            initUrl += "r=" + GetTime(2) + "&lang=zh_CN&pass_ticket=" + passticket;
            HttpHelper http = new HttpHelper();
            Deviceid = DeviceID();
            var data = new { BaseRequest=new { Uin = wxuin, Sid = wxsid, Skey = skey, DeviceID = Deviceid } };
            string json = JsonConvert.SerializeObject(data);
            HttpItem item = new HttpItem()
            {
                URL = initUrl,
                Method = "post",
                Accept = "application/json, text/plain, */*",
                Postdata = json,
                Cookie = HttpCookie,
                ContentType = "application/json;charset=UTF-8"
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html;
            var Inininfo = JsonConvert.DeserializeObject<dynamic>(html);
            wxusername = Inininfo.User.UserName;
            return true;
        }


        //6.返回好友列表的Json字符串.
        public static string Memberlist()
        {
           
            ContactUrl +="&pass_ticket=" +passticket+ "&r=" + GetTime(1)+ "&seq=0&skey=" + skey;
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = ContactUrl,
                Method = "get",
                Encoding = Encoding.UTF8,
                Cookie = HttpCookie,
                Accept = "application/json, text/plain, */*"
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html;
            
            return html;
        }

        //7.获取好友的头像.
        public static Image CreateHttpimg(string url)
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = url,
                Cookie = HttpCookie,
                ResultType = ResultType.Byte
            };
            HttpResult result = http.GetHtml(item);
            return byteArrayToImage(result.ResultByte);
        }

        //8.微信发送文本消息.
        public static bool SendTextMessage(string Content,string ToUserName)
        {
            SendMessageUrl +=passticket+ "&lang=zh_CN";
            HttpHelper http = new HttpHelper();
            Deviceid = DeviceID();
            string LocalId = LocalID();
            var data = new { BaseRequest = new { Uin = wxuin, Sid = wxsid, Skey = skey, DeviceID = Deviceid }, Msg = new { ClientMsgId = LocalId, Content = Content, LocalID = LocalId, FromUserName = wxusername, ToUserName = ToUserName, Type = 1 } ,Scene =0};
            string json = JsonConvert.SerializeObject(data);
            HttpItem item = new HttpItem()
            {
                URL = SendMessageUrl,
                PostEncoding=Encoding.UTF8,
                Encoding=Encoding.UTF8,
                Accept = "application/json, text/plain, */*",
                ContentType = "application/json;charset=UTF-8",//返回类型    可选项有默认值
                Method = "post",
                Postdata = json,
                Cookie = HttpCookie,
            };
            item.Header.Add("Accept-Encoding", "gzip, deflate, br");
            item.Header.Add("Accept-Language", "zh-CN,zh;q=0.8");
            HttpResult result = http.GetHtml(item);
            string html = result.Html;
            return true;
        }

        //9.微信上传文件的处理
        public static string UploadFile(string FileAddress)
        {
            //要Post的数据
            string postfile = FileAddress;
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = "http://www.sufeinet.com",//URL     必需项    
                Method = "post",//URL     可选项 默认为Get   
                ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值
                PostDataType = PostDataType.FilePath,
                Postdata = postfile
            };
            //请求的返回值对象
            HttpResult result = http.GetHtml(item);
            //获取请请求的Html
            string html = result.Html;
            //获取请求的Cookie
            string cookie = result.Cookie;
            System.IO.File.WriteAllText(@"D:\html.txt",html);
            return html;
        }


        //A.byteArray转图片处理
        private static Image byteArrayToImage(byte[] Bytes)
        {
            MemoryStream ms = new MemoryStream(Bytes);
            Image outputImg = Image.FromStream(ms);
            return outputImg;
        }


        //B.返回时间戳,1毫秒级,2秒级
        public static string GetTime(int type)
        {
            string Time = null;
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            switch (type)
            {
                case 1:
                    Time = Convert.ToInt64(ts.TotalMilliseconds).ToString();
                    break;
                case 2:
                    Time = Convert.ToInt64(ts.TotalSeconds).ToString();
                    break;
                default:
                    break;
            }
            return Time;
        }

        //B.返回微信需要的DeviceID
        public static string DeviceID()
        {
            Random ran = new Random();
            string DeviceID = "e";
            for (var i = 0; i < 15; i++)
            {
                DeviceID += ran.Next(0, 9);
            }
            return DeviceID;
        }

        //C.返回微信需要的LocalID/ClientMsgId
        public static string LocalID()
        {
            Random ran = new Random();
            return GetTime(1)+"0"+ ran.Next(100, 999);
          
        }
    }
}
