using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Gyms
{
    public class WeightliftingGym : Gym
    {
        private static int weightliftingGymCapacity = 20;
        public WeightliftingGym(string name) : base(name, weightliftingGymCapacity)
        {
        }

        public override string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a WeightliftingGym:");
            List<string> athletesNames = new List<string>();
            if (this.Athletes.Count>0)
            {
                foreach(var at in this.Athletes)
                {
                    athletesNames.Add(at.FullName);
                }
                sb.AppendLine("Atheletes: " + String.Join(", ", athletesNames));
            }
            else
            {
                sb.AppendLine("Athletes: No athletes");
            }

            sb.AppendLine($"Equipment total count: {this.Equipment.Count}");
            sb.AppendLine($"Equipment total weight: {this.EquipmentWeight:F2} grams");

            return sb.ToString().TrimEnd();
        }
    }
}
