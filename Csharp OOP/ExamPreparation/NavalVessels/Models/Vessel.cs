using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public abstract class Vessel : IVessel
    {
        public Vessel(string name, double mainWeaponCaliber, 
            double speed, double armorThickness)
        {
            this.Name = name;
            this.MainWeaponCaliber = mainWeaponCaliber;
            this.Speed = speed;
            this.ArmorThickness = armorThickness;
            this.targets = new List<string>();
        }

        private string name;
        private ICaptain captain;
        private List<string> targets;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Vessel name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICaptain Captain 
        {
            get
            {
                return this.captain;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Captain cannot be null.");
                }

                this.captain = value;
            }
        }
        public double ArmorThickness { get;  set; }

        public double MainWeaponCaliber { get; protected set; }

        public double Speed { get; protected set; }

        public ICollection<string> Targets => this.targets;

        public void Attack(IVessel target)
        {
            if(target==null)
            {
                throw new NullReferenceException("Target cannot be null.");
            }

            target.ArmorThickness -= this.MainWeaponCaliber;
            if(target.ArmorThickness<0)
            {
                target.ArmorThickness = 0;
            }

            this.targets.Add(target.Name);
        }

        public abstract void RepairVessel();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Armor thickness: {this.ArmorThickness}");
            sb.AppendLine($" *Main weapon caliber: {this.MainWeaponCaliber}");
            sb.AppendLine($" *Speed: {this.Speed} knots");
            if (this.Targets.Count > 0)
            {
                sb.AppendLine(" *Targets: "+String.Join(", ", this.Targets));
            }
            else
            {
                sb.AppendLine(" *Targets: None");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
