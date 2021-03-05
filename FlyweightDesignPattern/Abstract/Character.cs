using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern.Abstract
{
    public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;

        public abstract void State();
    }
}
