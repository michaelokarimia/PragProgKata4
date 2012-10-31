using Moq;
using NUnit.Framework;
using WeatherPart1;
using WeatherPart1.Repository;

namespace WeatherUnitTests
{
    [TestFixture]
    public class TextDataParserTests
    {
        private IDataParser subject;
        private string validDataFile;
        private Mock<IMapper> dataMapperMock;

        [SetUp]
        public void Setup()
        {
            dataMapperMock= new Mock<IMapper>();
            subject = new TextDataParser(validDataFile, dataMapperMock.Object);
        }

        [Test]
        public void MapsDataSourceToResultsRepository()
        {
            dataMapperMock.Setup(x => x.Map(It.IsAny<string>())).Returns(new WeatherDataResultsRepository());
            subject = new TextDataParser(validDataFile, dataMapperMock.Object);

            var repository = subject.Read();

            dataMapperMock.Verify(x=>x.Map(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(typeof(WeatherDataResultsRepository),repository.GetType());
        }

    }

}
