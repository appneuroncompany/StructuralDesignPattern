using CompositeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern.Concrete
{
    public class UnconditionalSoldier : Soldier
    {

        public UnconditionalSoldier(string name, Rank rank) : base(name, rank) { }

        public override void AddSoldier(Soldier soldier)
        {
            Console.WriteLine("Asker yetkili değil!!!");
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            Console.WriteLine("Asker yetkili değil!!!");
        }
    }
}
