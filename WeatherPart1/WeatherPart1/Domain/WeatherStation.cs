using System.Collections.Generic;
using WeatherPart1.Calculators;
using WeatherPart1.OutputFormatter;
using WeatherPart1.Parser;


namespace WeatherPart1.Domain
{
    public class WeatherStation : IWeatherStation
    {
        private readonly IDataParser<WeatherParsedEntity> dataParser;
        private readonly ICalculator<IParsedEntity> calculator;
        private readonly IOutputFormatter outputFormatter;
        private List<WeatherParsedEntity> parsedDataRepository;
        private ICalulatedSum result;

        public WeatherStation(IDataParser<WeatherParsedEntity> dataParser, ICalculator<IParsedEntity> calculator, IOutputFormatter outputFormatter)
        {
            this.dataParser = dataParser;
            this.calculator = calculator;
            this.outputFormatter = outputFormatter;
        }

        public void ParseWeatherData()
        {
            parsedDataRepository = dataParser.GetResultList();
        }

   
        public void CalculateTemperatureSpread()
        {
            result = calculator.Calculate(parsedDataRepository);
        }

        public IParsedEntity OutputResults()
        {
            return outputFormatter.OutputResults();
        }
    }
}