using AdapterDesignPattern.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Model.Concrete
{
    public class PlugIn
    {
        public void PuluginElectricalAppliance(IElectricalAppliance electricApplience)
        {
            electricApplience.Plugin();
        }
    }
}
