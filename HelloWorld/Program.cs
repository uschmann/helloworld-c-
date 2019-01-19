using HelloWorld.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.WeatherClient;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new TimeLogger();
            IWeatherClient client = new FlurlWeatherClient();
            SalutationBuilder salutationBuilder = new SalutationBuilder();
            Greeter greeter = new Greeter(logger, salutationBuilder);

            logger.Print("Calling OpenWeatherMap");

            Weather weather = client.getWeather("Oberhausen");

            logger.Print(weather.name);
            
            Console.ReadLine();
        }
    }
}
