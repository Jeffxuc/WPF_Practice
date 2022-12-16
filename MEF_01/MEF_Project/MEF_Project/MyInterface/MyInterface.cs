using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    /// <summary>
    /// 接受数据
    /// </summary>
    /// <param name="dataFromID"></param>
    /// <param name="receiveData"></param>
    public delegate void EventHandlerReceiveData(
        int dataFromID,
        string receiveData);

    /// <summary>
    /// 请求数据
    /// </summary>
    /// <param name="senderID"></param>
    /// <param name="receiverPath"></param>
    /// <param name="requestData"></param>
    /// <param name="receiveEvent"></param>
    public delegate void EventHandlerRequestData(
        int senderID,
        string requestData,
        EventHandlerReceiveData receiveEvent);

    /// <summary>
    /// 定义接口类型
    /// </summary>
    public interface IMyInterface
    {
        event EventHandlerReceiveData EventReceiveData;
        event EventHandlerRequestData EventRequestData;

        string GetPluginName();
        int GetPluginId();

        /// <summary>
        /// 主页面向各个子Plugin广播消息，子Plugin接受到消息后实现各自的处理方式，
        /// 在此将其放到Interface中是希望后面各个Plugin的接口一致，也可以让各个Plugin以自己的方式来进行定义实现。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="receiveData"></param>
        void ReceiveDataCallBack(int id, string receiveData);
    }
}
