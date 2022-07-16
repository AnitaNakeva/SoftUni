using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Models
{
    public class Paladin:BaseHero
    {
        public Paladin(string name) : base(name)
        {
            base.Power = 100;
        }

        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {this.Power}";
        }
    }
}
