using Moq;
using NUnit.Framework;
using WeatherPart1;
using WeatherPart1.Domain;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherStationTests
    {
        private WeatherStation subject;
        private Mock<IDataParser> dataParser;
        private Mock<ITemperatureCalculator> temperatureCalculator;
        private Mock<IOutputFormatter> resultsOutputter;

        [SetUp]
        public void Setup()
        {
            dataParser = new Mock<IDataParser>();
            temperatureCalculator = new Mock<ITemperatureCalculator>();
            resultsOutputter = new Mock<IOutputFormatter>();
            subject = new WeatherStation(dataParser.Object, temperatureCalculator.Object, resultsOutputter.Object);
        }

        [Test]
        public void CanReadWeatherDataFile()
        {
            subject.ParseWeatherData();
            dataParser.Verify(x=>x.Read(), Times.Once());
        }

        [Test]
        public void CanCalculateTemperatureSpreads()
        {
            subject.CalculateTemperatureSpread();
            temperatureCalculator.Verify(x => x.Calculate(), Times.Once());
        }

        [Test]
        public void CanOutputResults()
        {
            subject.OutputResults();
            resultsOutputter.Verify(x => x.OutputResults(), Times.Once());
        }
    }
}
