using NUnit.Framework;
using WeatherPart1.Domain;
using WeatherPart1.Mapper;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherMapperTests
    {
        private WeatherMapper subject;
        private const string LINE_OF_VALID_WEATHER_DATA= "   1  88    59    74          53.8       0.00 F       280  9.6 270  17  1.6  93 23 1004.5";
        private WeatherResult weatherResult;

        [SetUp]
        public void Setup()
        {
            subject = new WeatherMapper();
            weatherResult = subject.Map(LINE_OF_VALID_WEATHER_DATA);
        }

        [Test]
        public void CanMapDay()
        {
            
            Assert.AreEqual(1,weatherResult.Day);
        }

        [Test]
        public void CanMapMaxTemperature()
        {
            Assert.AreEqual(88d, weatherResult.MaxTemperature);
        }

        [Test]
        public void CanMapMinTemperature()
        {
            Assert.AreEqual(59d, weatherResult.MinTemperature);
        }
    }
}
