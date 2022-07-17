using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Exceptions
{
    public class WrongType:Exception
    {
        public WrongType(string message):base(message)
        {

        }
    }
}
