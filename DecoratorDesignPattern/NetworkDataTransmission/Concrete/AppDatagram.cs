using DecoratorDesignPattern.NetworkDataTransmission.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.NetworkDataTransmission.Concrete
{
    public class AppDatagram : IDatagram
    {
        public void SendData()
        {
            Console.WriteLine("Ip datagram gönderildi...");
        }
    }
}
