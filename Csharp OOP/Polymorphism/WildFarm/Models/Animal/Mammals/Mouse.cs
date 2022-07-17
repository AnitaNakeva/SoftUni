using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{
    using Food;
    public class Mouse : Mammal
    {
        private const double mouseWeightMult = 0.1;
        public Mouse(string name, double weight, string LivingRegion) : base(name, weight, LivingRegion)
        {
        }

        protected override double WeightMultiplier => mouseWeightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type> { typeof(Vegetable), typeof(Fruit) }.AsReadOnly();

        public override string MakeASound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
