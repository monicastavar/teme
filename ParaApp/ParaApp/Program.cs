using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ParaApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //    convert from unix timestamp -ok
            //    convert from gtm  + 2h 
            
            string url = "https://api.darksky.net/forecast/706c97e950a58d75f85434f7952d552d/47.3,27.52";
            var jsonResponse = getResponse(url);
            Console.WriteLine(jsonResponse);

        
            //    sa ruleze dimineata la 8 pt a doua zi
            var obj = JObject.Parse(jsonResponse);
            var field = (string)obj.SelectToken("data.img_url");


            Console.ReadKey();

            var weatherPerHours = new List<HourlyWeather>
            {
            new HourlyWeather { WindSpeed = 0, WindGust = 0 WindBearing = 0 PrecipProbability= 0, Hour=12/12/2017},
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing="", PrecipProbability="", Hour=""},
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing="", PrecipProbability="", Hour=""},
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing="", PrecipProbability="", Hour=""}, FirstName = "Flori", LastName = "Duru" },
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing = "", PrecipProbability = "", Hour = "" },
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing = "", PrecipProbability = "", Hour = "" },
            new HourlyWeather { WindSpeed = "", WindGust = "", WindBearing = "", PrecipProbability = "", Hour = "" }
            };

            var listOfHourlyPrognosis = new WeatherAnalysis { PrognosisList = weatherPerHours };
        }
        static string getResponse(String endpoint)
        {
            string textResponse;         

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();            
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                textResponse = reader.ReadToEnd();
            }
            return textResponse;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();

            //convert GTM to Bucharest time
            dtDateTime = dtDateTime.AddHours(2);
            return dtDateTime;
        }


    }
}
