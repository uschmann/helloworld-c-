using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace HelloWorld.WeatherClient
{
    public class FlurlWeatherClient : IWeatherClient
    {
        public Weather getWeather(string city)
        {
            return "https://api.openweathermap.org/data/2.5/weather"
                .SetQueryParams(new {
                    q = city,
                    appid = ""
                })
                .GetJsonAsync<Weather>()
                .Result;
        }
    }
}
