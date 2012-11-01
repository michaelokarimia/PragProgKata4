using NUnit.Framework;
using WeatherPart1.Domain;
using WeatherPart1.Dto;
using WeatherPart1.Mapper;

namespace WeatherUnitTests
{
    [TestFixture]
    public class WeatherMapperTests
    {
        private WeatherMapper subject;
        private const string LINE_OF_VALID_WEATHER_DATA= "   1  88    59    74          53.8       0.00 F       280  9.6 270  17  1.6  93 23 1004.5";
        private WeatherParsedEntity weatherParsedEntity;

        [SetUp]
        public void Setup()
        {
            subject = new WeatherMapper();
            weatherParsedEntity = subject.Map(LINE_OF_VALID_WEATHER_DATA);
        }

        [Test]
        public void CanMapDay()
        {
            
            Assert.AreEqual(1,weatherParsedEntity.Day);
        }

        [Test]
        public void CanMapMaxTemperature()
        {
            Assert.AreEqual(88d, weatherParsedEntity.MaxTemperature);
        }

        [Test]
        public void CanMapMinTemperature()
        {
            Assert.AreEqual(59d, weatherParsedEntity.MinTemperature);
        }
    }
}
