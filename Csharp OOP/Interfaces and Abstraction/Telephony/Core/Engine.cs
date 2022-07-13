using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Core
{
    using IO.Interfaces;
    using Telephony.Models;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly StationaryPhone stationaryPhone;
        private readonly Smartphone smartphone;

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer):this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Start()
        {
            string[] phoneNumbers = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = this.reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach(string phoneNumber in phoneNumbers)
            {
                if(!this.ValidateNum(phoneNumber))
                {
                    this.writer.WriteLine("Invalid number!");
                }
                else if(phoneNumber.Length==10)
                {
                    this.writer.WriteLine(this.smartphone.Call(phoneNumber));

                }
                else if(phoneNumber.Length==7)
                {
                    this.writer.WriteLine(this.stationaryPhone.Call(
                        phoneNumber));
                }
            }

            foreach (string url in urls)
            {
                if (!this.ValidateURL(url))
                {
                    this.writer.WriteLine("Invalid URL!");
                }
                else
                {
                    this.writer.WriteLine(this.smartphone.BrowseURL(url));
                }
            }
        }

        private bool ValidateNum(string num)
        {
            foreach (char n in num)
            {
                if (!Char.IsDigit(n))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateURL(string url)
        {
            foreach (char n in url)
            {
                if (Char.IsDigit(n))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
