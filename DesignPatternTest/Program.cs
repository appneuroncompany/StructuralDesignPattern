using AdapterDesignPattern;
using BridgeDesignPattern;
using DecoratorDesignPattern;
using FacadeDesignPattern;
using FlyweightDesignPattern;
using ProxyDesignPattern;
using System;

namespace DesignPatternTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //AdapterDesign.TestAdapterDesign();
            //DecoratorDesign.TestDecoratorDesign();
            //BridgeDesign.TestBridgeDesign();
            //FacadeDesign.ManageData();
            //ProxyDesign.TestProxyDesign();
            FlyweightDesign.TestFlyweightDesign("AAABBBCCCAAAABACABCABACACBAB");
        }
    }
}
