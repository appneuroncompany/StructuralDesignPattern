using AdapterDesignPattern.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Model.Concrete
{
    public class TelefonEEAAdapter : IElectricalAppliance
    {
        ITelephone telephone;
        public TelefonEEAAdapter(ITelephone telephone)
        {
            this.telephone = telephone;
        }

        public void Plugin()
        {
            telephone.Charager();

        }
    }
}
