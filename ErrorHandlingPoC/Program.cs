using ErrorHandlingPoC.Classes.Handlers;
using ErrorHandlingPoC.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingPoC
{
    public class Program
    {
        internal static List<IHandler> allHandlersIUse = new();

        public static List<IHandler> GetAllHandlers()
        {
            List<IHandler> ListOfHandlers = new();
            foreach(Type T in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(T.IsAssignableFrom(typeof(IHandler)) && T != typeof(IHandler))
                {
                    if(T is IHandler H)
                    {
                        ListOfHandlers.Add(H);
                    }
                }
            }
            return ListOfHandlers;
        }

        public static void Main()
        {
            Program.allHandlersIUse = Program.GetAllHandlers();
            foreach (IHandler Handler in Program.allHandlersIUse)
            {
                try
                {
                    Handler.Handle();
                }
                catch (Exception E)
                {
                    Handler.OnError(E);
                    File.WriteAllText(@"\AllErrorLogs.txt", $"{Handler.Name} had an issue!\n{E.Message}");
                }
            }
        }
    }
}
