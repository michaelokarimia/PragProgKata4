using System.Collections.Generic;
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

        private string columnHeaders = "  Dy MxT   MnT   AvT   HDDay  AvDP 1HrP TPcpn WxType PDir AvSp Dir MxS SkyC MxR MnR AvSLP";
        private static readonly string endOfDailyWeatherSection = "</pre>";

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
                bool isADailyWeatherRecord = false;
                while ((line = inputReader.ReadLine()) != null)
                {
                    if (line == columnHeaders || isADailyWeatherRecord)
                    {
                        if (!isADailyWeatherRecord)
                        {
                            inputReader.ReadLine();
                            isADailyWeatherRecord = true;
                        }
                        if (line.Contains(endOfDailyWeatherSection))
                        {
                            return weatherResultList;
                        }
                        
                        line = inputReader.ReadLine();
                        weatherParsedEntity = dataMapper.Map(line);
                        weatherResultList.Add(weatherParsedEntity);
                    }
                }
            }
            return weatherResultList;
        }
    }
}