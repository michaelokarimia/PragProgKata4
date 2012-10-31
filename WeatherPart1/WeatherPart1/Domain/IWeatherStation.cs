namespace WeatherPart1.Domain
{
    internal interface IWeatherStation
    {
        void ParseWeatherData();
        void CalculateTemperatureSpread();
        IResult OutputResults();
    }
}