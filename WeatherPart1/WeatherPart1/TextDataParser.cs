using WeatherPart1.Repository;

namespace WeatherPart1
{
    public class TextDataParser : IDataParser
    {
        private readonly string validDataFilePath;
        private readonly IMapper dataMapper;
        private IResultRepository resultRepository;

        public TextDataParser(string validDataFilePath, IMapper dataMapper)
        {
            this.validDataFilePath = validDataFilePath;
            this.dataMapper = dataMapper;
        }

        public IResultRepository Read()
        {
            resultRepository = dataMapper.Map(validDataFilePath);
            return resultRepository;
        }
    }
}