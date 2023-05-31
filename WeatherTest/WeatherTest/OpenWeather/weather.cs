using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTest.OpenWeather
{
    class weather // параметры weather
    {
        public int id;

        public string main;

        public string description;

        public string icon;

        public Bitmap Icon
        {
            get
            {
                return new Bitmap(Image.FromFile($"icons/{icon}.png")); // получение картинки из папки icons через шаблон
            }
        }
    }
}
