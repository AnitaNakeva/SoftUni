using ConsoleApp144.Interfaces;
using ConsoleApp144.Models;
using System;

namespace ConsoleApp144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var cmdArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = cmdArgs[0];
                var country = cmdArgs[1];
                var age = int.Parse(cmdArgs[2]);
                var citizen = new Citizen(name, country, age);
                IPerson iPerson = citizen;
                IResident iResident = citizen;
                Console.WriteLine(iPerson.GetName());
                Console.WriteLine(iResident.GetName());
            }
        }
    }
}
