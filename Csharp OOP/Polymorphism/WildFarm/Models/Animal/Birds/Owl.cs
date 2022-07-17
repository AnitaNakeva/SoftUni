using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Birds
{
    using Food;
    public class Owl : Bird
    {
        private const double owlWightMult = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiplier => owlWightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type>{typeof(Meat)}.AsReadOnly();

        public override string MakeASound()
        {
            return "Hoot Hoot";
        }
    }
}
