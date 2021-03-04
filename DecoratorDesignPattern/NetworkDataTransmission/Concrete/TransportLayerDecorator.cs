using DecoratorDesignPattern.NetworkDataTransmission.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.NetworkDataTransmission.Concrete
{
    public abstract class TransportLayerDecorator : IDatagram
    {
        readonly IDatagram datagram;
        public TransportLayerDecorator(IDatagram datagram)
        {
            this.datagram = datagram;
        }
        public virtual void SendData()
        {
            datagram.SendData();
        }
    }
}
