using System.Globalization;
using WeatherPart1.Domain;

namespace WeatherPart1.Mapper
{
    public class WeatherMapper : IMapper
    {
        private const int MIN_TEMP_INDEX = 9;
        private const int DAY_INDEX = 3;
        private const char SEPARATOR = ' ';
        private const int MAX_TEMP_INDEX = 5;

        public WeatherResult Map(string validLineOfWeatherDataRow)
        {
            new WeatherResult();
            var columnsOfLine = validLineOfWeatherDataRow.Split(SEPARATOR);
            int day;
            decimal maxTemp;
            decimal minTemp;
            int.TryParse(columnsOfLine[DAY_INDEX], out day);
            decimal.TryParse(columnsOfLine[MAX_TEMP_INDEX], out maxTemp);
            decimal.TryParse(columnsOfLine[MIN_TEMP_INDEX], out minTemp);

            return new WeatherResult(day, maxTemp, minTemp);
            
        }
    }
}