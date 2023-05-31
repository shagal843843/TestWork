using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherTest.OpenWeather
{
    internal class OpenWeather // все параметры json
    {
        public coord coord;

        public weather[] weather;

        [JsonProperty("base")]
        public string Base;

        public main main;

        public double visibility;

        public wind wind;

        public clouds clouds;

        public double dt;

        public sys sys;

        public double timezone;

        public int id;

        public string name;

        public double cod;
    }
}
