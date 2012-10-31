using System;

namespace WeatherPart1
{
    public class WeatherStation : IWeatherStation
    {
        private readonly IDataParser dataParser;

        public WeatherStation(IDataParser dataParser)
        {
            this.dataParser = dataParser;
        }

        public void ParseWeatherData()
        {
            dataParser.Read();
        }

        public void CalculateTemperatureSpread()
        {
            throw new NotImplementedException();
        }

        public void OutputResults()
        {
            throw new NotImplementedException();
        }
    }
}