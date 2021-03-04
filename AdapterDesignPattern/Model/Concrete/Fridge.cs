using AdapterDesignPattern.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Model.Concrete
{
    public class Fridge : IElectricalAppliance
    {

        public int voltage
        {
            get { return 220; }
        }

        public void Plugin()
        {
            Console.WriteLine("Buzdolabı prize takıldı. Voltage:  " + voltage);
        }
    }
}
