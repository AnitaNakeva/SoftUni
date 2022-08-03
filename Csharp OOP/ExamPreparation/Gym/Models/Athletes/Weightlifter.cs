﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Weightlifter : Athlete
    {
        private static int weightlifterStamina = 50;
        public Weightlifter(string fullName, string motivation, int numberOfMedals) : base(fullName, motivation, numberOfMedals, weightlifterStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += 10;
            if (this.Stamina > 100)
            {
                this.Stamina = 100;
                throw new ArgumentException("Stamina cannot exceed 100 points.");
            }
        }
    }
}
