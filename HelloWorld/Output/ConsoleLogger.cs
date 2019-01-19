using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Output
{
    class ConsoleLogger : ILogger
    {

       public void Print(String text)
       {
            Console.WriteLine(text);
       }
    }
}
