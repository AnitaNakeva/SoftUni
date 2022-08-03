using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class BoxingGloves : Equipment
    {
        private static double boxingGlovesWeight = 227;
        private static decimal boxingGlovesPrice = 120;
        public BoxingGloves() : base(boxingGlovesWeight, boxingGlovesPrice)
        {
        }
    }
}
