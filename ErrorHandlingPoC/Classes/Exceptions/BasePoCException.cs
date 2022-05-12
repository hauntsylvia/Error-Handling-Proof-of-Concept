using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingPoC.Classes.Exceptions
{
    public class BasePoCException : Exception
    {
        public BasePoCException(string? Message) : base(Message)
        {
        }
    }
}
