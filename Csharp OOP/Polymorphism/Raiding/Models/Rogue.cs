using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Models
{
    public class Rogue:BaseHero
    {
        public Rogue(string name) : base(name)
        {
            base.Power = 80;
        }
        public override string CastAbility()
        {
            return $"Rogue - {this.Name} hit for {this.Power} damage";
        }
    }
}
