using System;
using System.IO;
using Moq;
using NUnit.Framework;
using WeatherPart1;
using WeatherPart1.Domain;
using WeatherPart1.IO;
using WeatherPart1.Mapper;
using WeatherPart1.Parser;

namespace WeatherUnitTests
{
    [TestFixture]
    public class TextDataParserTests
    {
        private IDataParser subject;
        private Mock<IMapper> dataMapperMock;
        private Mock<IInputReader> inputReaderMock;
        private string oneLineOfTestText;
        private Mock<InputReaderFactory> inputReaderFactoryMock;

        [SetUp]
        public void Setup()
        {
            dataMapperMock= new Mock<IMapper>();
            inputReaderMock = new Mock<IInputReader>();
            oneLineOfTestText = "first Line of txt";
            inputReaderFactoryMock = new Mock<InputReaderFactory>();
            
            inputReaderMock.Setup(x => x.ReadLine()).Returns(() => oneLineOfTestText).Callback(() => oneLineOfTestText = null);

            inputReaderFactoryMock.Setup(x => x.GetReader(It.IsAny<string>())).Returns(inputReaderMock.Object);
        }

        [Test]
        public void MapsDataSourceToResultsRepository()
        {
            dataMapperMock.Setup(x => x.Map(It.IsAny<string>())).Returns(new WeatherResult());

            subject = new TextDataParser(It.IsAny<string>(), dataMapperMock.Object, inputReaderFactoryMock.Object);
            
            subject.GetResultList();

            dataMapperMock.Verify(x=>x.Map(It.IsAny<string>()), Times.Once());
        }

    }

}
