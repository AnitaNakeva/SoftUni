using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private List<IPlanet> exploredPlanets;
        private PlanetRepository planets;
        public Controller()
        {
            this.planets = new PlanetRepository();
            this.astronauts = new AstronautRepository();
            this.exploredPlanets = new List<IPlanet>();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            if(type=="Biologist")
            {
                Biologist biologist = new Biologist(astronautName);
                astronauts.Add(biologist);
            }
            else if(type== "Geodesist")
            {
                Geodesist geodesist = new Geodesist(astronautName);
                astronauts.Add(geodesist);
            }
            else if(type=="Meteorologist")
            {
                Meteorologist meteorologist = new Meteorologist(astronautName);
                astronauts.Add(meteorologist);
            }
            else
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            Planet planet = new Planet(planetName);
            foreach(string item in items)
            {
                planet.Items.Add(item);
            }
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            var astToGo = this.astronauts.Models.Where(x=>x.Oxygen>60).ToList();
            Mission mission = new Mission();
            var planet = this.planets.FindByName(planetName);
            if (astToGo.Count == 0)
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet");
            }
            mission.Explore(planet, astToGo);
            var deadAst = astToGo.Where(x => x.CanBreath != true).ToList();
            exploredPlanets.Add(planet);
            return $"Planet: {planetName} was explored! Exploration finished with {deadAst.Count} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanets.Count} planets were explored!");
            sb.AppendLine("Astronauts info:");
            var ast = this.astronauts.Models.ToList();
            foreach (var a in ast)
            {
                sb.AppendLine($"Name: {a.Name}");
                sb.AppendLine($"Oxygen: {a.Oxygen}");
                if(a.Bag.Items.Count>0)
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", a.Bag.Items)}");
                }
                else
                {
                    sb.AppendLine("Bag items: none");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public void Exit()
        {
            Exit();
        }

        public string RetireAstronaut(string astronautName)
        {
            if(astronauts.FindByName(astronautName)==null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
            var ast = astronauts.FindByName(astronautName);
            astronauts.Remove(ast);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}
