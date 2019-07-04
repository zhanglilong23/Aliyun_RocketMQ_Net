using Aliyun.MQ;
using Aliyun.MQ.Model;
using Aliyun.MQ.Util;
using System;

namespace NetCoreDemo
{
    
    class Program
    {
        /*
         *1 注意，本项目使用的是RocketMQ http 连接方式
         *2 首先请引入项目：Aliyun_MQ_Standard_SDK 生成的DLL。
         *3 使用Sample中的发布、订阅方法。
         * 
         * 下面以发布为示例
         */

        //发布示例

        // 设置HTTP接入域名，注意，必须是HTTP，TCP不可以。
        private static string _endpoint = "http://xxxx.mqrest.cn-qingdao-public.aliyuncs.com";
        // AccessKey 阿里云身份验证，在阿里云服务器管理控制台创建
        private static string _accessKeyId = "xxxx";
        // SecretKey 阿里云身份验证，在阿里云服务器管理控制台创建
        private static string _secretAccessKey = "xxxx";
        // 所属的 Topic
        private static string _topicName = "xxxx";
        // Topic所属实例ID，一般都有。
        private static string _instanceId = "xxxx";

        private static MQClient _client = new Aliyun.MQ.MQClient(_accessKeyId, _secretAccessKey, _endpoint);
        static MQProducer producer = _client.GetProducer(_instanceId, _topicName);

        static void Main(string[] args)
        {
            try
            {
                // 循环发送4条消息
                for (int i = 0; i < 4; i++)
                {
                    TopicMessage sendMsg;
                    if (i % 2 == 0)
                    {
                        sendMsg = new TopicMessage($"你好啊:{i.ToString()}");
                        // 设置属性
                        sendMsg.PutProperty("a", i.ToString());
                        // 设置KEY
                        sendMsg.MessageKey = "MessageKey";
                    }
                    else
                    {
                        sendMsg = new TopicMessage($"你好啊xx:{i.ToString()}", $"tag{i}");
                        // 设置属性
                        sendMsg.PutProperty("a", i.ToString());
                        // 定时消息, 定时时间为10s后
                        sendMsg.StartDeliverTime = AliyunSDKUtils.GetNowTimeStamp() + 10 * 1000;
                    }
                    TopicMessage result = producer.PublishMessage(sendMsg);
                    Console.WriteLine("publis message success:" + result);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
