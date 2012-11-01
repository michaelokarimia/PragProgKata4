using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WeatherPart1.Calculators;
using WeatherPart1.Domain;
using WeatherPart1.Dto;
using WeatherPart1.IO;
using WeatherPart1.Mapper;
using WeatherPart1.OutputFormatter;
using WeatherPart1.Parser;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherStationAcceptanceTests
    {
        private WeatherStation subject;
        private IDataParser<WeatherParsedEntity> dataParser;
        private string weatherFilePath = @"C:\git\prag-prog-katas\Kata-4\WeatherPart1\WeatherPart1\Data\weather.dat";
        private IMapper mapper;
        private InputReaderFactory inputReaderFactory;
        private IOutputFormatter<string, MaxDaySpread> outputFormatter;
        private ICalculator<WeatherParsedEntity, MaxDaySpread> calculator;

        [SetUp]
        public void Setup()
        {
            mapper = new WeatherMapper();
            inputReaderFactory = new InputReaderFactory();
            dataParser = new TextDataParser(weatherFilePath, mapper, inputReaderFactory);
            
            calculator = new TemperatureSpreadCalculator();

            outputFormatter = new MaximumDayTemperatureOutputFormatter();

            subject = new WeatherStation(dataParser,calculator,outputFormatter);
        }

        [Test]
        public void CanReadFromWeatherFileAndFindDayWithLowestTemperatureSpread()
        {
            
            subject.ParseWeatherData();
            subject.CalculateTemperatureSpread();
            Assert.AreEqual("43", subject.OutputResults());
        }
    }
}
