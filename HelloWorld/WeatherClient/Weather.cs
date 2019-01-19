using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.WeatherClient
{
    public class Weather
    {
        public String name;
        public Main main;

        public class Main {

            public float temp;
            public int pressure;
            public int humidity;
            public float temp_min;
            public float temp_max;
        }
    }
}
