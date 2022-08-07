using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;
        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                FreshwaterAquarium frAq = new FreshwaterAquarium(aquariumName);
                this.aquariums.Add(frAq);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                SaltwaterAquarium slAq = new SaltwaterAquarium(aquariumName);
                this.aquariums.Add(slAq);
            }
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                Ornament ornament = new Ornament();
                this.decorations.Add(ornament);
            }
            else if (decorationType == "Plant")
            {
                Plant plant = new Plant();
                this.decorations.Add(plant);
            }
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if(fishType == "FreshwaterFish")
            {
                FreshwaterFish frFish = new FreshwaterFish(fishName, fishSpecies, price);
                var aqToAddTo = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
                if (aqToAddTo.GetType().Name == "FreshwaterAquarium")
                {
                    aqToAddTo.AddFish(frFish);
                    return $"Successfully added {fishType} to {aquariumName}.";
                }
                else
                {
                    return "Water not suitable.";
                }
            }
            else if (fishType == "SaltwaterFish")
            {
                SaltwaterFish slFish = new SaltwaterFish(fishName, fishSpecies, price);
                var aqToAddTo = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
                if (aqToAddTo.GetType().Name == "SaltwaterAquarium")
                {
                    aqToAddTo.AddFish(slFish);
                    return $"Successfully added {fishType} to {aquariumName}.";
                }
                else
                {
                    return "Water not suitable.";
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid fish type.");
            }
        }

        public string CalculateValue(string aquariumName)
        {
            decimal valueFish = 0;
            decimal valueDecorations = 0;

            var aq = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            foreach(var f in aq.Fish)
            {
                valueFish += f.Price;
            }
            foreach (var d in aq.Decorations)
            {
                valueDecorations += d.Price;
            }

            decimal value = valueDecorations + valueFish;
            return $"The value of Aquarium {aquariumName} is {value:F2}.";
        }

        public string FeedFish(string aquariumName)
        {
            int count = 0;
            var aqToFeed = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            foreach(var f in aqToFeed.Fish)
            {
                f.Eat();
                count++;
            }

            return $"Fish fed: {count}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decToInsert = this.decorations.FindByType(decorationType);
            if(decToInsert==null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}."); 
            }
            else
            {
                var aqToAddTo = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
                aqToAddTo.AddDecoration(decToInsert);
                this.decorations.Remove(decToInsert);
                return $"Successfully added {decorationType} to {aquariumName}.";
            }
        }

        public void Exit()
        {
            Exit();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var aq in this.aquariums)
            {
                sb.AppendLine(aq.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
