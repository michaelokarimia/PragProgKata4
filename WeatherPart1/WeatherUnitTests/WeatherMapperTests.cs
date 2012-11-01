using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WeatherPart1.Mapper;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherMapperTests
    {
        private WeatherMapper subject;
        private string lineOfValidWeatherData= "   1  88    59    74          53.8       0.00 F       280  9.6 270  17  1.6  93 23 1004.5";

        [SetUp]
        public void Setup()
        {
            subject = new WeatherMapper();
        }

        [Test]
        public void CanMapDay()
        {
            var weatherResult = subject.Map(lineOfValidWeatherData);
            Assert.AreEqual(1,weatherResult.Day);
        }

        [Test]
        public void CanMapMaxTemperature()
        {
            var weatherResult = subject.Map(lineOfValidWeatherData);
            Assert.AreEqual(88d, weatherResult.MaxTemperature);
        }
    }
}
