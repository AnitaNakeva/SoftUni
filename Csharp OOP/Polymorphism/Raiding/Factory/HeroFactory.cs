using ConsoleApp137.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Factory
{
    public class HeroFactory : IHeroFactory
    {
        public BaseHero CreateHero(string name, string type)
        {
           if(type == "Druid")
            {
                return new Druid(name);
            }
           else if(type == "Paladin")
            {
                return new Paladin(name);
            }
           else if (type == "Rogue")
            {
                return new Rogue(name);
            }
           else if(type == "Warrior")
            {
                return new Warrior(name);
            }
           else
            {
                throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
