using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class Kettlebell : Equipment
    {
        private static double kettlebellWeight = 10000;
        private static decimal kettlebellPrice = 80;
        public Kettlebell() : base(kettlebellWeight, kettlebellPrice)
        {
        }
    }
}
