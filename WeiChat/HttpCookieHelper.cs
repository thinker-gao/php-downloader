using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WeiChat
{
    /// <summary>  
    /// Cookie操作帮助类  
    /// </summary>  
    public static class HttpCookieHelper
    {

        public static string GetSmallCookie(string strcookie)
        {
            string result;
            if (string.IsNullOrWhiteSpace(strcookie))
            {
                result = string.Empty;
            }
            else
            {
                List<string> list = new List<string>();
                string[] array = strcookie.ToString().Split(new string[]
                {
                    ",",
                    ";"
                }, StringSplitOptions.RemoveEmptyEntries);
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    string text2 = text.ToLower().Trim().Replace("\r\n", string.Empty).Replace("\n", string.Empty);
                    if (!string.IsNullOrWhiteSpace(text2))
                    {
                        if (text2.Contains("="))
                        {
                            if (!text2.Contains("path="))
                            {
                                if (!text2.Contains("expires="))
                                {
                                    if (!text2.Contains("domain="))
                                    {
                                        if (!list.Contains(text))
                                        {
                                            list.Add(string.Format("{0};", text));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                result = string.Join(";", list);
            }
            return result.Replace(";;", ";");
        }





        /// <summary>  
        /// 根据字符生成Cookie列表  
        /// </summary>  
        /// <param name="cookie">Cookie字符串</param>  
        /// <returns></returns>  
        public static List<CookieItem> GetCookieList(string cookie)
        {
            List<CookieItem> cookielist = new List<CookieItem>();
            foreach (string item in cookie.Split(new string[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (Regex.IsMatch(item, @"([\s\S]*?)=([\s\S]*?)$"))
                {
                    Match m = Regex.Match(item, @"([\s\S]*?)=([\s\S]*?)$");
                    cookielist.Add(new CookieItem() { Key = m.Groups[1].Value, Value = m.Groups[2].Value });
                }
            }
            return cookielist;
        }

        /// <summary>  
        /// 根据Key值得到Cookie值,Key不区分大小写  
        /// </summary>  
        /// <param name="Key">key</param>  
        /// <param name="cookie">字符串Cookie</param>  
        /// <returns></returns>  
        public static string GetCookieValue(string Key, string cookie)
        {
            foreach (CookieItem item in GetCookieList(cookie))
            {
                if (item.Key == Key)
                    return item.Value;
            }
            return "";
        }
        /// <summary>  
        /// 格式化Cookie为标准格式  
        /// </summary>  
        /// <param name="key">Key值</param>  
        /// <param name="value">Value值</param>  
        /// <returns></returns>  
        public static string CookieFormat(string key, string value)
        {
            return string.Format("{0}={1};", key, value);
        }
    }

    /// <summary>  
    /// Cookie对象  
    /// </summary>  
    public class CookieItem
    {
        /// <summary>  
        /// 键  
        /// </summary>  
        public string Key { get; set; }
        /// <summary>  
        /// 值  
        /// </summary>  
        public string Value { get; set; }
    }
}