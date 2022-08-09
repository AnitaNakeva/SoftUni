using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private List<IRace> executedRaces;
        private List<IPilot> pilots;
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public Controller()
        {
            this.executedRaces = new List<IRace>();
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
            this.pilots = new List<IPilot>();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilotToFind = this.pilotRepository.FindByName(pilotName);
            //if (pilotToFind == null || pilotToFind.Car != null)
            if (pilotToFind == null || pilotToFind.CanRace == true)
            {
                throw new InvalidOperationException($"Pilot { pilotName } does not exist or has a car.");
            }
            var carModelToFind = this.carRepository.FindByName(carModel);
            if (carModelToFind == null)
            {
                throw new NullReferenceException($"Car { carModel } does not exist.");
            }

            pilotToFind.AddCar(carModelToFind);
            this.carRepository.Remove(carModelToFind);

            return $"Pilot { pilotName } will drive a {carModelToFind.GetType().Name} { carModel } car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var race = this.raceRepository.FindByName(raceName);
            if(race==null)
            {
                throw new NullReferenceException($"Race { raceName } does not exist.");
            }
            var pilot = this.pilotRepository.FindByName(pilotFullName);
            if (pilot == null || pilot.CanRace != true || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException($"Can not add pilot { pilotFullName } to the race.");
            }

            race.AddPilot(pilot);

            return $"Pilot { pilotFullName } is added to the { raceName } race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (type == "Ferrari")
            {
                var modelToFind = this.carRepository.FindByName(model);
                if(modelToFind!=null)
                {
                    throw new InvalidOperationException($"Formula one car { model } is already created.");
                }
                else
                {
                    Ferrari ferrari = new Ferrari(model, horsepower, engineDisplacement);
                    this.carRepository.Add(ferrari);
                }
            }
            else if (type == "Williams")
            {
                var modelToFind = this.carRepository.FindByName(model);
                if (modelToFind != null)
                {
                    throw new InvalidOperationException($"Formula one car { model } is already created.");
                }
                else
                {
                    Williams williams = new Williams(model, horsepower, engineDisplacement);
                    this.carRepository.Add(williams);
                }
            }
            else
            {
                throw new InvalidOperationException($"Formula one car type { type } is not valid.");
            }

            return $"Car { type }, model { model } is created.";
        }

        public string CreatePilot(string fullName)
        {
            var pilotToCreate = this.pilotRepository.FindByName(fullName);
            if(pilotToCreate!=null)
            {
                throw new InvalidOperationException($"Pilot { fullName } is already created.");
            }
            Pilot pilot = new Pilot(fullName);
            this.pilotRepository.Add(pilot);
            this.pilots.Add(pilot);

            return $"Pilot { fullName } is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            var raceToCreate = this.raceRepository.FindByName(raceName);
            if (raceToCreate != null)
            {
                throw new InvalidOperationException($"Race { raceName } is already created.");
            }
            Race race = new Race(raceName, numberOfLaps);
            this.raceRepository.Add(race);
            this.executedRaces.Add(race);

            return $"Race { raceName } is created.";
        }

        public string PilotReport()
        {
            StringBuilder sb = new StringBuilder();
            var orderedPilots = this.pilots.OrderByDescending(x => x.NumberOfWins);
            foreach(var pilot in orderedPilots)
            {
                sb.AppendLine($"Pilot {pilot.FullName} has {pilot.NumberOfWins} wins.");
            }

            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var race in this.executedRaces)
            {
                if (race.TookPlace)
                {
                    sb.AppendLine($"The { race.RaceName } race has:");
                    sb.AppendLine($"Participants: { race.Pilots.Count }");
                    sb.AppendLine($"Number of laps: { race.NumberOfLaps }");
                    sb.AppendLine("Took place: Yes");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            var race = this.raceRepository.FindByName(raceName);
            if(race==null)
            {
                throw new NullReferenceException($"Race { raceName } does not exist.");
            }
            else if(race.Pilots.Count<3)
            {
                throw new InvalidOperationException($"Race { raceName } cannot start with less than three participants.");
            }
            else if(race.TookPlace==true)
            {
                throw new InvalidOperationException($"Can not execute race { raceName }.");
            }

            race.TookPlace = true;
            var winner = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).Take(1).ToList();
            var orderedPilots = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).Take(3).ToList();
            winner[0].WinRace();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                if(i==0)
                {
                    sb.AppendLine($"Pilot { orderedPilots[0].FullName } wins the { raceName } race.");
                }
                else if(i==1)
                {
                    sb.AppendLine($"Pilot { orderedPilots[1].FullName } is second in the { raceName } race.");
                }
                else
                {
                    sb.AppendLine($"Pilot { orderedPilots[2].FullName } is third in the { raceName } race.");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public void Exit()
        {
            Exit();
        }
    }
}
