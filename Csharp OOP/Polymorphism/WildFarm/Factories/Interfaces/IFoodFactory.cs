using ConsoleApp138.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Factories.Interfaces
{
    public interface IFoodFactory
    {
        Food CreateFood(string type, int quantity);
    }
}
