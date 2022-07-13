using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> people = new Queue<string>();
            while (true)
            {
                if (command == "Paid")
                {
                    while (people.Count > 0)
                    {
                        string person = people.Dequeue();
                        Console.WriteLine(person);
                    }
                }

                else if (command == "End")
                {
                    Console.WriteLine(people.Count + " people remaining.");
                    break;
                }

                else
                {
                    people.Enqueue(command);
                }

                command = Console.ReadLine();
            }

        }
    }
}
