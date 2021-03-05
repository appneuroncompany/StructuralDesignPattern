using BridgeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Concrete
{
    public class HumanoidController : CharController
    {
        public HumanoidController(Humanoidchar humanoidchar) : base(humanoidchar) { }

    }
}
