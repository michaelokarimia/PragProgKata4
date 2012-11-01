using WeatherPart1.Domain;

namespace WeatherPart1.Dto
{
    public class WeatherParsedEntity :IParsedEntity
    {
        public WeatherParsedEntity(int day, decimal maxTemp, decimal minTemp)
        {
            Day = day;
            MaxTemperature = maxTemp;
            MinTemperature = minTemp;
        }

        public WeatherParsedEntity() {}

        public int Day { get; private set; }

        public decimal MaxTemperature { get; private set; }

        public decimal MinTemperature { get; private set; }
    }
}