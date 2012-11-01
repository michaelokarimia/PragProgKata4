using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WeatherPart1.Calculators;
using WeatherPart1.Dto;
using WeatherPart1.OutputFormatter;

namespace WeatherUnitTests
{
    [TestFixture]
    public class OutputFormatterTests
    {
        private MaximumDayTemperatureOutputFormatter subject;
        private MaxDaySpread weatherStationData;
        private string expectedString ="Maximum Temperature spread was during Day 20";

        [SetUp]
        public void Setup()
        {
            weatherStationData = new MaxDaySpread(20);
            subject = new MaximumDayTemperatureOutputFormatter(weatherStationData);
        }

        [Test]
        public void CanOutputStringDayNumber()
        {
            Assert.AreEqual(expectedString, subject.OutputResults());
        }
    }
}
