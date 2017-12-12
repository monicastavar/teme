using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaApp
{
    public class WeatherAnalysis
    {
        public List<HourlyWeather> PrognosisList { get; set; }

        public IEnumerable<HourlyWeather> checkConditionsPerHour()
        {
            IEnumerable<HourlyWeather> weatherConditionsList = PrognosisList
                .Where((n, i) => Enumerable.Range(1, 100).Contains(n.WindSpeed)
                && Enumerable.Range(1, 100).Contains(n.WindGust)
                && Enumerable.Range(1, 100).Contains(n.WindBearing)
                && n.PrecipProbability == 0);

            return weatherConditionsList;
        }

        public bool chooseToSendNotifcation()
        {
            bool sendNotification = false;
            IEnumerable<HourlyWeather> weatherConditionsList = checkConditionsPerHour();
            int counter = 0;
            for (int i = 1; i< weatherConditionsList.Count(); i++)
            {                
                if ((weatherConditionsList.ElementAt(i).hour - weatherConditionsList.ElementAt(i-1).hour).Hours == 1)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter == 3)
                {
                    sendNotification = true;
                    break;
                }
            }
            return sendNotification;
        }
    }
    
}
