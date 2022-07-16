using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136.Models
{
    public interface IVehicle
    {
        double TankCapacity { get; }

        double FuelQuantity { get; }

        double FuelConsumption { get; }

        string Drive(double distance);

        void Refuel(double liters);

        string DriveEmpty(double distance);
    }
}
