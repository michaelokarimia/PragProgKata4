using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            subject = new WeatherStation(dataParser.Object);
        }

        [Test]
        public void CanReadWeatherDataFile()
        {
            dataParser.Verify(x=>x.Read(), Times.Once());
        }
    }
}
