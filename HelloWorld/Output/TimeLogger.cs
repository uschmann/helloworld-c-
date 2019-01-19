using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Output
{
    class TimeLogger : ILogger
    {
        public void Print(string text)
        {
            Console.WriteLine("[" + DateTime.Now.ToString("MM/dd/yyyy, HH:mm") + "]: " + text);
        }
    }
}
