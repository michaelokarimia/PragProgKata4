using WeatherPart1.Repository;

namespace WeatherPart1
{
    public interface IMapper
    {
        IResultRepository Map(string validDataFilePath);
    }
}