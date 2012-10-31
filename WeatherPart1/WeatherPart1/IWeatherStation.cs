namespace WeatherPart1
{
    internal interface IWeatherStation
    {
        void ParseWeatherData();
        void CalculateTemperatureSpread();
        void OutputResults();
    }
}