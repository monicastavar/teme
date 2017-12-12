using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaApp
{
    public class HourlyWeather
    {
        public int WindSpeed { get; set; }
        public int WindGust { get; set; }
        public int WindBearing { get; set; }      
        public int PrecipProbability { get; set; }
        public DateTime Hour { get; set; }
    }
}
