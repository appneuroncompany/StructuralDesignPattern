using AdapterDesignPattern.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Model.Concrete
{
    public class Samsung : ITelephone
    {
        public int voltage { get => 5; set => voltage = value; }

        public void Charager()
        {
            Console.WriteLine("Şarja takıldı. Voltajı: " + voltage);
        }
    }
}
