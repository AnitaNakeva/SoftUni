using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models
    
{
using Interfaces;
public class StationaryPhone : ICallable
{
    public string Call(string number)
    {
        //if(!this.ValidateNum(number))
        //    {
        //        return "Invalid number!";
        //    }

            return $"Dialing... {number}";
    }


}
}
