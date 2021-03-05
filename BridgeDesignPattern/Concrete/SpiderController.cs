using BridgeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Concrete
{
    public class SpiderController : CharController
    {
        public SpiderController(SpiderChar spiderChar) : base(spiderChar) { }

    }
}
