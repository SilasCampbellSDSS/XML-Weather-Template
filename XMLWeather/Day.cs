using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, condition, precipitation, precipitationType, futureClouds, futurePrecipitationType, precipitationChance, location, tempHigh, tempLow, feelsLike, icon;

        public Day()
        {
            date = currentTemp = condition = location = futureClouds = tempHigh = tempLow = futurePrecipitationType = precipitation = precipitationChance = feelsLike = precipitationType = icon = "";
        }
    }
}
