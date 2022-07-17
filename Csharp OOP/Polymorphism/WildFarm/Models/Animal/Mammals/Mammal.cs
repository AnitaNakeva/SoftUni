using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get;}
        protected Mammal(string name, double weight, string LivingRegion) : base(name, weight)
        {
            this.LivingRegion = LivingRegion;
        }
    }
}
