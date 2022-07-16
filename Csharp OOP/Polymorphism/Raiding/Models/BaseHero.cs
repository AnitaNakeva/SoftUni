using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Models
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public int Power { get; protected set; }
        public abstract string CastAbility();
    }
}
