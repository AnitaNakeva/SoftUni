using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Models
{
    public class Warrior:BaseHero
    {
        public Warrior(string name) : base(name)
        {
            base.Power = 100;
        }

        public override string CastAbility()
        {
            return $"Warrior - {this.Name} hit for {this.Power} damage";
        }
    }
}
