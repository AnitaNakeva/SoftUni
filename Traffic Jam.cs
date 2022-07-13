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
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int countPassed = 0;
            while (true)
            {
                if (command == "end")
                {
                    Console.WriteLine(countPassed + " cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string carToPass = cars.Dequeue();
                            Console.WriteLine(carToPass + " passed!");
                            countPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
        }
    }
}
