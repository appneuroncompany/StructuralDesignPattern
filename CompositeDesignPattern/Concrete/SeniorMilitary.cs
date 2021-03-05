using CompositeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDesignPattern.Concrete
{
    public class SeniorMilitary : Soldier
    {

        List<Soldier> soldiers = new List<Soldier>();

        public SeniorMilitary(string name, Rank rank) : base(name, rank) { }

        public override void AddSoldier(Soldier soldier)
        {
            soldiers.Add(soldier);
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));
            foreach (Soldier soldier in soldiers)
            {
                soldier.ExecuteOrder();
            }
        }

        public override void RemoveSoldier(Soldier soldier)
        {
            Soldier Selectedsoldier = soldiers.SingleOrDefault(r => r._name == soldier._name);
            soldiers.Remove(Selectedsoldier);
        }
    }
}
