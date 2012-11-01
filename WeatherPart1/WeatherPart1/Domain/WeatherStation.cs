using System.Collections.Generic;
using WeatherPart1.Calculators;
using WeatherPart1.Dto;
using WeatherPart1.OutputFormatter;
using WeatherPart1.Parser;


namespace WeatherPart1.Domain
{
    public class WeatherStation : IWeatherStation
    {
        private readonly IDataParser<WeatherParsedEntity> dataParser;
        private readonly ICalculator<WeatherParsedEntity, MaxDaySpread> calculator;
        private readonly IOutputFormatter<string> outputFormatter;
        private List<WeatherParsedEntity> parsedDataRepository;
        private ICalulatedResult result;

        public WeatherStation(IDataParser<WeatherParsedEntity> dataParser, ICalculator<WeatherParsedEntity, MaxDaySpread> calculator, IOutputFormatter<string> outputFormatter)
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

        public string OutputResults()
        {
            return outputFormatter.OutputResults();
        }
    }
}