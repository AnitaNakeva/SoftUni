using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Boxer : Athlete
    {
        private static int boxerStamina = 60;
        public Boxer(string fullName, string motivation, int numberOfMedals) : base(fullName, motivation, numberOfMedals, boxerStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += 15;
            if (this.Stamina > 100)
            {
                this.Stamina = 100;
                throw new ArgumentException("Stamina cannot exceed 100 points.");
            }
        }
    }
}
