using FlyweightDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Concrete
{
    public class CharA : Character
    {
        //Constructor
        public CharA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
        }

        public override void State()
        {
            Console.WriteLine("symbol: " + this.symbol + "\n" + "height: " +  this.height + "\n"  + "width: " + this.width);
        }
    }
}
