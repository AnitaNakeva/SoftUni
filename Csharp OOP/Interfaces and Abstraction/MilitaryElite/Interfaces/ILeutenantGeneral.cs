using ConsoleApp142.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142.Interfaces
{
    public interface ILeutenantGeneral
    {
        ICollection<Private> Privates { get; }
    }
}
