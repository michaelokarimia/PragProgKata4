using WeatherPart1.Domain;

namespace WeatherPart1.Mapper
{
    public interface IMapper
    {
        WeatherResult Map(string vsalidLineOfWeatherData);
    }
}