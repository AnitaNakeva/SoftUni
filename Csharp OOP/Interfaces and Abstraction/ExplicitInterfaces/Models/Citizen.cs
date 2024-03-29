﻿using ConsoleApp144.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp144.Models
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        public string Name { get; }

        public string Country { get; }

        public int Age { get; }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        string IPerson.GetName()
        {
            return this.Name;
        }

        
    }
}
