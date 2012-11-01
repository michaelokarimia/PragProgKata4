using System.Collections.Generic;
using WeatherPart1.Domain;
using WeatherPart1.Dto;

namespace WeatherPart1.Calculators
{
    public class TemperatureSpreadCalculator : ICalculator<WeatherParsedEntity, MaxDaySpread>
    {
        public MaxDaySpread Calculate(List<WeatherParsedEntity> results)
        {
            var dayNumber = -1;
            decimal maxSpread = 0;
            foreach (WeatherParsedEntity weatherParsedEntity in results)
            {
                var currentspread = weatherParsedEntity.MaxTemperature - weatherParsedEntity.MinTemperature;
                if (currentspread > maxSpread)
                {
                    maxSpread = currentspread;
                    dayNumber = weatherParsedEntity.Day;
                }
            }

            return new MaxDaySpread(dayNumber);
        }
    }
}