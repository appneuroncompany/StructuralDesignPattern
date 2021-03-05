using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Abstract
{
    public interface IDataSender
    {
        bool CheckInternetConnection();
        void SendMessageWithRestClient(string message);

    }
}
