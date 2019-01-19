using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.WeatherClient
{
    public interface IWeatherClient
    {

        Weather getWeather(String city);

    }
}
