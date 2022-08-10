using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel,IBattleship
    {
        private bool sonarMode;
        public bool SonarMode 
        { 
            get
            {
                return this.sonarMode;
            }
            private set
            {
                this.sonarMode = value;
            }
        }
        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
        {
            this.SonarMode = false;
        }

        public override void RepairVessel()
        {
            this.ArmorThickness = 300;
        }

        public void ToggleSonarMode()
        {
            if (this.SonarMode)
            {
                this.SonarMode = false;
            }
            else
            {
                this.SonarMode = true;
            }

            if (this.SonarMode)
            {
                base.MainWeaponCaliber += 40;
                base.Speed -= 5;
            }
            else
            {
                base.MainWeaponCaliber -= 40;
                base.Speed += 5;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (this.SonarMode)
            {
                sb.AppendLine(" *Sonar mode: ON");
            }
            else
            {
                sb.AppendLine(" *Sonar mode: OFF"); 
            }

            return sb.ToString().TrimEnd();
        }
    }
}
