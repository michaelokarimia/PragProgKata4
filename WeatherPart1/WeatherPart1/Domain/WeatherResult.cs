using System;

namespace WeatherPart1.Domain
{
    public class WeatherResult :IResult
    {
        public WeatherResult(int day, decimal maxTemp)
        {
            Day = day;
            MaxTemperature = maxTemp;
        }

        public WeatherResult() {}

        public int Day { get; private set; }

        public decimal MaxTemperature { get; private set; }
    }
}