using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{
    public abstract class Felice : Mammal
    {
        public string Breed { get; }
        protected Felice(string name, double weight, string LivingRegion, string breed) : base(name, weight, LivingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
