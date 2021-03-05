using BridgeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Concrete
{
    public class SpiderChar : ICharacter
    {
        public void fight()
        {
            Console.WriteLine("SpiderChar dövüşüyor...");
        }

        public void run()
        {
            Console.WriteLine("SpiderChar koşuyor...");
        }

        public void walk()
        {
            Console.WriteLine("SpiderChar yürüyor...");
        }
    }
}
