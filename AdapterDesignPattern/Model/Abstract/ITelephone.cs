using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Model.Abstract
{
    public interface ITelephone
    {
        int voltage { get; set; }

        void Charager();
    }
}
