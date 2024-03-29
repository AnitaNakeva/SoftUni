﻿using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        public Race(string raceName, int numberOfLaps)
        {
            this.TookPlace = false;
            this.pilots = new List<IPilot>();
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
        }

        private string raceName;
        private int numberOfLaps;
        private List<IPilot> pilots;

        public string RaceName
        {
            get
            {
                return this.raceName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid race name: { value }.");
                }
                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get
            {
                return this.numberOfLaps;
            }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException($"Invalid lap numbers: { value }.");
                }
                this.numberOfLaps = value;
            }
        }

        private bool tookPlace;
        public bool TookPlace
        {
            get
            {
                return this.tookPlace;
            }
            set
            {
                this.tookPlace = value;
            }
        }

        public ICollection<IPilot> Pilots => this.pilots;

        public void AddPilot(IPilot pilot)
        {
            this.pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The { this.RaceName } race has:");
            sb.AppendLine($"Participants: { this.pilots.Count }");
            sb.AppendLine($"Number of laps: { this.NumberOfLaps }");
            if (TookPlace)
            {
                sb.AppendLine("Took place: Yes");
            }
            else
            {
                sb.AppendLine("Took place: No");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
