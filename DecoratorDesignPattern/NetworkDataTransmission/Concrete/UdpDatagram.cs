using DecoratorDesignPattern.NetworkDataTransmission.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.NetworkDataTransmission.Concrete
{
    public class UdpDatagram : TransportLayerDecorator
    {
        public UdpDatagram(IDatagram datagram) : base(datagram) { }

        private void AddUDPHeader()
        {
            Console.WriteLine("Udp protokolü devreye sokuldu.");
        }
        public override void SendData()
        {
            AddUDPHeader();
            base.SendData();
        }
    }
}
