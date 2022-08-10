using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using NavalVessels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private VesselRepository vessels;
        private List<ICaptain> captains;
        public Controller()
        {
            this.vessels = new VesselRepository();
            this.captains = new List<ICaptain>();
        }
        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            var captain = this.captains.FirstOrDefault(x => x.FullName == selectedCaptainName);
            if(captain == null)
            {
                return $"Captain {selectedCaptainName} could not be found.";
            }

            var vessel = this.vessels.FindByName(selectedVesselName);
            if(vessel == null)
            {
                return $"Vessel {selectedVesselName} could not be found.";
            }

            if(vessel.Captain!=null)
            {
                return $"Vessel {selectedVesselName} is already occupied.";
            }

            captain.AddVessel(vessel);
            vessel.Captain = captain;

            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackingVessel = this.vessels.FindByName(attackingVesselName);
            var defendingVessel = this.vessels.FindByName(defendingVesselName);

            if (attackingVessel == null)
            {
                return $"Vessel {attackingVesselName} could not be found.";
            }
            if(defendingVessel == null)
            {
                return $"Vessel {defendingVesselName} could not be found.";
            }

            if(attackingVessel.ArmorThickness==0)
            {
                return $"Unarmored vessel {attackingVesselName} cannot attack or be attacked.";
            }
            if(defendingVessel.ArmorThickness==0)
            {
                return $"Unarmored vessel {defendingVesselName} cannot attack or be attacked.";
            }

            attackingVessel.Attack(defendingVessel);
            attackingVessel.Captain.IncreaseCombatExperience();
            defendingVessel.Captain.IncreaseCombatExperience();

            return $"Vessel {defendingVesselName} was attacked by vessel {attackingVesselName} - current armor thickness: {defendingVessel.ArmorThickness}.";
        }

        public string CaptainReport(string captainFullName)
        {
            var captain = this.captains.FirstOrDefault(x => x.FullName == captainFullName);
            return captain.Report();
        }

        public string HireCaptain(string fullName)
        {
            Captain captain = new Captain(fullName);
            if (this.captains.Contains(captain))
            {
                return $"Captain {fullName} is already hired.";
            }
            else
            {
                this.captains.Add(captain);
                return $"Captain {fullName} is hired.";
            }
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            if(vesselType == "Battleship")
            {
                var vessel = this.vessels.FindByName(name);
                if (vessel != null)
                {
                    return $"{vesselType} vessel {name} is already manufactured.";
                }
                else
                {
                    Battleship battleship = new Battleship(name, mainWeaponCaliber, speed);
                    this.vessels.Add(battleship);
                    return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
                }
            }
            else if(vesselType == "Submarine")
            {
                var vessel = this.vessels.FindByName(name);
                if (vessel != null)
                {
                    return $"{vesselType} vessel {name} is already manufactured.";
                }
                else
                {
                    Submarine submarine = new Submarine(name, mainWeaponCaliber, speed);
                    this.vessels.Add(submarine);
                    return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
                }
            }
            else
            {
                return "Invalid vessel type.";
            }
        }

        public string ServiceVessel(string vesselName)
        {
            var vessel = this.vessels.FindByName(vesselName);
            if (vessel == null)
            {
                return $"Vessel {vesselName} could not be found.";
            }

            vessel.RepairVessel();
            return $"Vessel {vesselName} was repaired.";
        }

        public string ToggleSpecialMode(string vesselName)
        {
            var vessel = this.vessels.FindByName(vesselName);
            if(vessel.GetType().Name=="Battleship")
            {
                var battleship = vessel as Battleship;
                battleship.ToggleSonarMode();
                return $"Battleship {vesselName} toggled sonar mode.";
            }
            else if(vessel.GetType().Name=="Submarine")
            {
                var submarine = vessel as Submarine;
                submarine.ToggleSubmergeMode();
                return $"Submarine {vesselName} toggled submerge mode.";
            }
            else
            {
                return $"Vessel {vesselName} could not be found.";
            }
        }

        public string VesselReport(string vesselName)
        {
            var vessel = this.vessels.FindByName(vesselName);
            return vessel.ToString();
        }
    }
}
