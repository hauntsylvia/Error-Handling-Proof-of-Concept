using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingPoC.Classes.Interfaces
{
    public interface IHandler
    {
        Task Handle();
        Task OnError(Exception Thrown);
    }
}
