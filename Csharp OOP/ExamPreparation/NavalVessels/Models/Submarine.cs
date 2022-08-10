using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
        {
            this.SubmergeMode = false;
        }

        private bool submergeMode;

        public bool SubmergeMode
        {
            get
            {
                return this.submergeMode;
            }
            private set
            {
                this.submergeMode = value;
            }
        }

        public override void RepairVessel()
        {
            base.ArmorThickness = 200;
        }

        public void ToggleSubmergeMode()
        {
            if(this.SubmergeMode)
            {
                this.SubmergeMode = false;
                base.MainWeaponCaliber -= 40;
                base.Speed += 4;
            }
            else
            {
                this.SubmergeMode = true;
                base.MainWeaponCaliber += 40;
                base.Speed -= 4;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (this.SubmergeMode)
            {
                sb.AppendLine(" *Submerge mode: ON");
            }
            else
            {
                sb.AppendLine(" *Submerge mode: OFF");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
