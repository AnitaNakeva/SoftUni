using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            this.data = new List<Car>();
        }

        public int Count => this.data.Count;

        public void Add(Car car)
        {
            if(this.data.Count<this.Capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            var carToRem = this.data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (carToRem == null)
            {
                return false;
            }
            else
            {
                this.data.Remove(carToRem);
                return true;
            }
        }

        public Car GetLatestCar()
        {
            if (this.data.Count == 0)
            {
                return null;
            }
            else
            {
                var orderedData = this.data.OrderByDescending(x => x.Year).ToList();
                return orderedData[0];
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            var carToRem = this.data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (carToRem == null)
            {
                return null;
            }
            else
            {
                return carToRem;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach(var car in this.data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }

}
