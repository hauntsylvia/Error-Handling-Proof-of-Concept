using ErrorHandlingPoC.Classes.Exceptions;
using ErrorHandlingPoC.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingPoC.Classes.Handlers
{
    public class IHandleStuff : IHandler
    {
        public IHandleStuff()
        {
        }

        public string Name => "Example Handler";

        public Task Handle()
        {
            throw new BasePoCException("This was a forceful handler error!");
        }

        public Task OnError(Exception E)
        {
            // do stuff on error !!!
            Console.WriteLine(E.Message);
            return Task.CompletedTask;
        }
    }
}
