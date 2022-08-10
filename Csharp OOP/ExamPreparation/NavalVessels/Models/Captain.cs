using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Captain : ICaptain
    {
        public Captain(string fullName)
        {
            this.FullName = fullName;
            this.vessels = new List<IVessel>();
            this.CombatExperience = 0;
        }

        private int combatExperience;
        private string fullName;
        private List<IVessel> vessels;
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Captain full name cannot be null or empty string.");
                }

                this.fullName = value;
            }
        }

        public int CombatExperience
        {
            get { return this.combatExperience; }
            private set { this.combatExperience = value; }
        }
        public ICollection<IVessel> Vessels => this.vessels;

        public void AddVessel(IVessel vessel)
        {
            if(vessel==null)
            {
                throw new NullReferenceException("Null vessel cannot be added to the captain.");
            }

            this.vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            this.CombatExperience += 10;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FullName} has {this.CombatExperience} combat experience and commands {this.Vessels.Count} vessels.");

            if (this.Vessels.Count > 0)
            {
                foreach(var vessel in this.Vessels)
                {
                    sb.AppendLine(vessel.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
