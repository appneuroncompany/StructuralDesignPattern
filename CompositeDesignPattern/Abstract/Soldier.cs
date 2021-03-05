using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Abstract
{
    public abstract class Soldier
    {
        public string _name;
        public Rank _rank;

        public Soldier(string name, Rank rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
        public abstract void ExecuteOrder();
    }
}