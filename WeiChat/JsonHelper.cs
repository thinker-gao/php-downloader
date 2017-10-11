/// <summary>  
/// 类说明：SerializerJsonHelper  
/// 编 码 人：苏飞  
/// 联系方式：361983679    
/// 更新网站：http://www.sufeinet.com/thread-655-1-1.html  
/// </summary>  
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;

namespace DotNet.Utilities.Json
{
    public class JsonHelper
    {
        // 从一个对象信息生成Json串  
        public static string ObjectToJson(object obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }
        // 从一个Json串生成对象信息  
        public static object JsonToObject(string jsonString, object obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return serializer.ReadObject(mStream);
            }

        }
    }
}
