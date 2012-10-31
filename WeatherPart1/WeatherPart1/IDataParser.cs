using WeatherPart1.Repository;

namespace WeatherPart1
{
    public interface IDataParser
    {
        IResultRepository Read();
    }
}