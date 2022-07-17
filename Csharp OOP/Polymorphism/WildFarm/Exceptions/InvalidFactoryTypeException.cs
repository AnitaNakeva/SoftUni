using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Exceptions
{
    public class InvalidFactoryTypeException:Exception
    {
        private const string DefaultMessage = "Invalid type!";

        public InvalidFactoryTypeException()
            : base(DefaultMessage)
        {

        }

        public InvalidFactoryTypeException(string message)
            : base(message)
        {

        }
    }
}
