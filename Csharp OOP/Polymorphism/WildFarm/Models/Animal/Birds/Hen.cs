using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Birds
{
    using Food;
    public class Hen : Bird
    {
        private const double henWeightMult = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiplier => henWeightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type> { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) }.AsReadOnly();

        public override string MakeASound()
        {
            return "Cluck";
        }
    }
}
