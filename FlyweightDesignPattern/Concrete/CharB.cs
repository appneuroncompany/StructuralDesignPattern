using FlyweightDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Concrete
{
    public class CharB : Character
    {
        public CharB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
        }

        public override void State()
        {
            Console.WriteLine("symbol: " + this.symbol + "\n" + "height: " + this.height + "\n" + "width: " + this.width);
        }
    }
}
