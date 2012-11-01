using System.Collections.Generic;
using WeatherPart1.Domain;
using WeatherPart1.Dto;
using WeatherPart1.IO;
using WeatherPart1.Mapper;

namespace WeatherPart1.Parser
{
    public class TextDataParser : IDataParser<WeatherParsedEntity>
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

        public List<WeatherParsedEntity> GetResultList()
        {
            WeatherParsedEntity weatherParsedEntity;
            var weatherResultList = new List<WeatherParsedEntity>();

           
            using (var inputReader = inputReaderFactory.GetReader(validDataFilePath))
            {
                string line;
                while ((line = inputReader.ReadLine()) != null)
                {
                    weatherParsedEntity = dataMapper.Map(line);
                    weatherResultList.Add(weatherParsedEntity);
                }
            }
            return weatherResultList;
        }
    }
}