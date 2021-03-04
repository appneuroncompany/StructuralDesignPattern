using DecoratorDesignPattern.NetworkDataTransmission.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.NetworkDataTransmission.Concrete
{
    public class TcpDatagram : TransportLayerDecorator
    {
        public TcpDatagram(IDatagram datagram) : base(datagram) { }

        private void AddTCPHeader()
        {
            Console.WriteLine("TCP protokolü devreye sokuldu.");
        }
        public override void SendData()
        {
            AddTCPHeader();
            base.SendData();
        }
    }
}
