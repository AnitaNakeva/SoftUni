using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{
    using Food;
    public class Dog:Mammal
    {
        private const double dogWeightMult = 0.4;
        public Dog(string name, double weight, string LivingRegion) : base(name, weight, LivingRegion)
        {
        }

        protected override double WeightMultiplier => dogWeightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type> { typeof(Meat) }.AsReadOnly();

        public override string MakeASound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
