namespace WeatherPart1.Domain
{
    public interface IWeatherStation
    {
        void ParseWeatherData();
        void CalculateTemperatureSpread();
        IParsedEntity OutputResults();
    }
}