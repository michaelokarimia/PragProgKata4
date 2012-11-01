using System.Collections.Generic;
using NUnit.Framework;
using WeatherPart1.Calculators;
using WeatherPart1.Dto;

namespace WeatherUnitTests
{
    [TestFixture]
    public class TemperatureSpreadCalculatorTest
    {
        private TemperatureSpreadCalculator subject;
        private List<WeatherParsedEntity> weatherResults;

        [SetUp]
        public void Setup()
        {
            subject = new TemperatureSpreadCalculator();
            weatherResults = new List<WeatherParsedEntity>();
        }


        [Test]
        public void ReturnsDayWithLargestSpread()
        {
            weatherResults = new List<WeatherParsedEntity>
                                 {new WeatherParsedEntity(17, 10, 0), new WeatherParsedEntity(2, 8, 6)};
            MaxDaySpread calulated = subject.Calculate(weatherResults);
            Assert.AreEqual(17, calulated.DayNumber);
        }
    }
}
