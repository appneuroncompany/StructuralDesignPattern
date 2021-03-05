using BridgeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.Concrete
{
    public class Humanoidchar : ICharacter
    {
        public void fight()
        {
            Console.WriteLine("HumanoidChar dövüşüyor...");
        }

        public void run()
        {
            Console.WriteLine("HumanoidChar koşuyor...");
        }

        public void walk()
        {
            Console.WriteLine("HumanoidChar yürüyor...");
        }
    }
}
