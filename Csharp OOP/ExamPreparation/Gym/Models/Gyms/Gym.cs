using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private int capacity;
        private List<IEquipment> equipment;
        private List<IAthlete> athletes;
        public Gym(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.equipment = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        private double sumOfEquipment()
        {
            double sum = 0;
            foreach(var eq in this.equipment)
            {
                sum += eq.Weight;
            }
            return sum;
        }
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public double EquipmentWeight => sumOfEquipment();

        public ICollection<IEquipment> Equipment => this.equipment;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (this.athletes.Count == capacity) 
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }

            this.athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach(var at in this.athletes)
            {
                at.Exercise();
            }
        }

        public abstract string GymInfo();

        public bool RemoveAthlete(IAthlete athlete)
        {
            return this.athletes.Remove(athlete);
        }
    }
}
