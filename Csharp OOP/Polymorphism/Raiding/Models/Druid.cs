using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
            base.Power = 80;
        }

        public override string CastAbility()
        {
            return $"Druid - {this.Name} healed for {this.Power}";
        }
    }
}
