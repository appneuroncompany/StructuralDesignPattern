using FlyweightDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Concrete
{
    public class CharC : Character
    {
        public CharC()
        {
            this.symbol = 'C';
            this.height = 100;
            this.width = 100;
        }

        public override void State()
        {
            Console.WriteLine("symbol: " + this.symbol + "\n" + "height: " + this.height + "\n" + "width: " + this.width);
        }
    }
}
