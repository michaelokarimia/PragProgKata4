using WeatherPart1.Domain;
using WeatherPart1.Dto;

namespace WeatherPart1.Mapper
{
    public interface IMapper
    {
        WeatherParsedEntity Map(string weatherDataRow);
    }
}