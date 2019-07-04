# Aliyun_RocketMQ_Net

### 如果你使用的是.Net Core 请忽略本项目，本项目基于阿里云官方项目而来，请直接查看阿里云官方的项目[mq-http-csharp-sdk](https://github.com/aliyunmq/mq-http-csharp-sdk)

### 首先，本项目使用的是RocketMQ中的 Http连接方式，截止于2019-7-1日，请确定你符合以下条件：
~~~
消息队列 RocketMQ 的 HTTP 协议，支持公网访问能力以及 7 种多语言的支持。当前有以下地域（Region）支持 HTTP 协议：

公网

华东 1（杭州）

华东 2（上海）

华北 1（青岛）

华北 2（北京）

华南 1（深圳）

德国（法兰克福）

其他地域后续也将陆续支持 HTTP 协议，敬请期待。
~~~


## 使用方法

### 1 首先请引入项目：Aliyun_MQ_Standard_SDK 生成的DLL。
### 2 参考阿里云官方Sample中的示例。
### 3 完成。

## 注明： 我不是大神，如有问题和bug，后续可能会修复，也可能需要大家自己解决。

## 啰嗦两句



![图1](https://github.com/zhanglilong23/Aliyun_RocketMQ_Net/blob/master/imgs/1.png)

### 如上图，请将 实例ID写入到 _instanceId 字段中。

### 如上图,请将HTTP协议接入点写入到 _endpoint 字段中。 _topicName 不再强调。




![图2](https://github.com/zhanglilong23/Aliyun_RocketMQ_Net/blob/master/imgs/2.png)


### 如上图, _groupId 填写的是HTTP协议下的 GroupID，TCP下的不行。

### 关于权限，请在RAM访问控制赋予用户 AliyunMQFullAccess 权限。

### 最后上成功图

![图3](https://github.com/zhanglilong23/Aliyun_RocketMQ_Net/blob/master/imgs/mqtest.png)




