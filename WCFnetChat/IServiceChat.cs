using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFnetChat
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceChat" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IServiceChatCallBack))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string Name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMsg(string msg, int id);
    }

    public interface IServiceChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallBack(string msg);
    }
}
