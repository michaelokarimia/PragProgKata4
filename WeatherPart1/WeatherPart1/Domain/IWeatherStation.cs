namespace WeatherPart1.Domain
{
    public interface IWeatherStation
    {
        void ParseWeatherData();
        void CalculateTemperatureSpread();
        string OutputResults();
    }
}