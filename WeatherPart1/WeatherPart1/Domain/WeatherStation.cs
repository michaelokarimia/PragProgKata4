using System.Collections.Generic;
using WeatherPart1.Calculators;
using WeatherPart1.OutputFormatter;
using WeatherPart1.Parser;


namespace WeatherPart1.Domain
{
    public class WeatherStation : IWeatherStation
    {
        private readonly IDataParser dataParser;
        private readonly ITemperatureCalculator temperatureCalculator;
        private readonly IOutputFormatter outputFormatter;
        private List<WeatherResult> resultsRepository;

        public WeatherStation(IDataParser dataParser, ITemperatureCalculator temperatureCalculator, IOutputFormatter outputFormatter)
        {
            this.dataParser = dataParser;
            this.temperatureCalculator = temperatureCalculator;
            this.outputFormatter = outputFormatter;
        }

        public void ParseWeatherData()
        {
            resultsRepository = dataParser.GetResultList();
        }

        public void CalculateTemperatureSpread()
        {
            temperatureCalculator.Calculate();
        }

        public IResult OutputResults()
        {
            return outputFormatter.OutputResults();
        }
    }
}