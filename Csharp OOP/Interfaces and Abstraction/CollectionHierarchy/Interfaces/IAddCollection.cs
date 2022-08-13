using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143.Interfaces
{
    public interface IAddCollection
    {
        List<string> Collection { get; }

        string Add(string item);
    }

}
