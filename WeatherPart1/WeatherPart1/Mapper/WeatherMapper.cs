using WeatherPart1.Domain;

namespace WeatherPart1.Mapper
{
    public class WeatherMapper : IMapper
    {
        private const int INDEX_OF_DAY = 3;
        private const char SEPARATOR = ' ';
        private const int INDEX_OF_MAX_TEMP = 5;

        public WeatherResult Map(string validLineOfWeatherData)
        {
            var result = new WeatherResult();
            var columnsOfLine = validLineOfWeatherData.Split(SEPARATOR);
            int day;
            decimal maxTemp;
            if(int.TryParse(columnsOfLine[INDEX_OF_DAY], out day) 
               && decimal.TryParse(columnsOfLine[INDEX_OF_MAX_TEMP], out maxTemp))
                result = new WeatherResult(day, maxTemp);
            return result;
        }
    }
}