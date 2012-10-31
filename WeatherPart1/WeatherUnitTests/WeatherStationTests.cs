using Moq;
using NUnit.Framework;
using WeatherPart1;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherStationTests
    {
        private WeatherStation subject;
        private Mock<IDataParser> dataParser;

        [SetUp]
        public void Setup()
        {
            dataParser = new Mock<IDataParser>();
            subject = new WeatherStation(dataParser.Object);
        }

        [Test]
        public void CanReadWeatherDataFile()
        {
            subject.ParseWeatherData();
            dataParser.Verify(x=>x.Read(), Times.Once());
        }
    }
}
