using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WeatherPart1.Calculators;
using WeatherPart1.Domain;

namespace WeatherUnitTests
{
    [TestFixture]
    public class TemperatureSpreadCalculatorcs
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
            MaxDaySpreadSum calulatedSum = subject.Calculate(weatherResults);
            Assert.AreEqual(17, calulatedSum.DayNumber);
        }
    }
}
