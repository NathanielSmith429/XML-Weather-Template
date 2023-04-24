using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windName, precipitationType, visibility, weatherNumber, weatherValue, humidity, dayOfWeek, precipitationChance;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windName = precipitationType = visibility = weatherNumber = weatherValue = humidity = dayOfWeek = precipitationChance = "";
        }
    }
}
