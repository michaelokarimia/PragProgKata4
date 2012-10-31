using WeatherPart1.Repository;

namespace WeatherPart1.Domain
{
    public class WeatherStation : IWeatherStation
    {
        private readonly IDataParser dataParser;
        private readonly ITemperatureCalculator temperatureCalculator;
        private readonly IOutputFormatter outputFormatter;
        private IResultRepository resultsRepository;

        public WeatherStation(IDataParser dataParser, ITemperatureCalculator temperatureCalculator, IOutputFormatter outputFormatter)
        {
            this.dataParser = dataParser;
            this.temperatureCalculator = temperatureCalculator;
            this.outputFormatter = outputFormatter;
        }

        public void ParseWeatherData()
        {
            resultsRepository = dataParser.Read();
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