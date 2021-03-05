using ProxyDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesignPattern.Concrete
{
    public class AbcBank : IBank
    {
     
        public bool Pay(int price)
        {
            Console.WriteLine("Ödeme yapıldı. Tutar: \n" + price);
            return true;
        }
    }
}
