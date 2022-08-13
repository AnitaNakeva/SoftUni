using ConsoleApp142.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142.Models
{
    public class LieutenantGeneral : ISoldier, IPrivate, ILeutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, double salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Privates = new HashSet<Private>();
        }

        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public double Salary { get; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
                .AppendLine("Privates:");
            foreach (var p in this.Privates)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString().Trim();
        }
        public ICollection<Private> Privates { get; }

        
    }
}
