using System.Collections.Generic;
using WeatherPart1.Domain;
using WeatherPart1.IO;
using WeatherPart1.Mapper;

namespace WeatherPart1.Parser
{
    public class TextDataParser : IDataParser
    {
        private readonly string validDataFilePath;
        private readonly IMapper dataMapper;
        private InputReaderFactory inputReaderFactory;

        public TextDataParser(string validDataFilePath, IMapper dataMapper, InputReaderFactory inputReaderFactory)
        {
            this.validDataFilePath = validDataFilePath;
            this.inputReaderFactory = inputReaderFactory;
            this.dataMapper = dataMapper;
        }

        public List<WeatherResult> GetResultList()
        {
            WeatherResult weatherResult;
            var weatherResultList = new List<WeatherResult>();

           
            using (var inputReader = inputReaderFactory.GetReader(validDataFilePath))
            {
                string line;
                while ((line = inputReader.ReadLine()) != null)
                {
                    weatherResult = dataMapper.Map(line);
                    weatherResultList.Add(weatherResult);
                }
            }
            return weatherResultList;
        }
    }
}