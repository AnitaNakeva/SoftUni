using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        public Controller()
        {
            this.gyms = new List<IGym>();
            this.equipment = new EquipmentRepository();
        }
        private EquipmentRepository equipment;
        private List<IGym> gyms;
        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            var gymToAddTo = this.gyms.FirstOrDefault(x => x.Name == gymName);
            if (athleteType == "Boxer")
            {
                if (gymToAddTo.GetType().Name != "BoxingGym")
                {
                    return "The gym is not appropriate.";
                }
                else
                {
                    Boxer boxer = new Boxer(athleteName, motivation, numberOfMedals);
                    gymToAddTo.AddAthlete(boxer);
                    return $"Successfully added {athleteType} to {gymName}.";
                }
             }
            else if(athleteType== "Weightlifter")
            {
                if (gymToAddTo.GetType().Name != "WeightliftingGym")
                {
                    return "The gym is not appropriate.";
                }
                else
                {
                    Weightlifter weightlifter = new Weightlifter(athleteName, motivation, numberOfMedals);
                    gymToAddTo.AddAthlete(weightlifter);
                    return $"Successfully added {athleteType} to {gymName}.";
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }
        }

        public string AddEquipment(string equipmentType)
        {
            if(equipmentType!= "BoxingGloves"&&equipmentType!= "Kettlebell")
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }
            else if(equipmentType== "BoxingGloves")
            {
                BoxingGloves newEq = new BoxingGloves();
                this.equipment.Add(newEq);
            }
            else
            {
                Kettlebell newKb = new Kettlebell();
                this.equipment.Add(newKb);
            }

            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            if(gymType!="BoxingGym"&&gymType!="WeightliftingGym")
            {
                throw new InvalidOperationException("Invalid gym type.");
            }
            else if(gymType=="BoxingGym")
            {
                BoxingGym newgym = new BoxingGym(gymName);
                this.gyms.Add(newgym);
            }
            else
            {
                WeightliftingGym newgym = new WeightliftingGym(gymName);
                this.gyms.Add(newgym);
            }
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            double eqWeight = 0;
            var gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            foreach(var eq in gym.Equipment)
            {
                eqWeight += eq.Weight;
            }
            return $"The total weight of the equipment in the gym {gymName} is {eqWeight:F2} grams.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            var eq = this.equipment.FindByType(equipmentType);
            if(eq==null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }
            else
            {
                var gymToAddTo = this.gyms.FirstOrDefault(x => x.Name == gymName);
                gymToAddTo.AddEquipment(eq);
                equipment.Remove(eq);
                return $"Successfully added {equipmentType} to {gymName}.";
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var gym in this.gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }
            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            int count = 0;
            var gymToTrain = this.gyms.FirstOrDefault(x => x.Name == gymName);
            foreach (var athlete in gymToTrain.Athletes)
            {
                athlete.Exercise();
                count++;
            }
            return $"Exercise athletes: {count}.";
        }

        public void Exit()
        {
            Exit();
        }
    }
}
