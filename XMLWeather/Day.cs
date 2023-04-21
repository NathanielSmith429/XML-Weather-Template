using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windName, precipitation, visibility, weatherNumber, weatherValue, humidity, dayOfWeek;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windName = precipitation = visibility = weatherNumber = weatherValue = humidity = dayOfWeek = "";
        }
    }
}
