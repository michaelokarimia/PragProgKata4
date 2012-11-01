using WeatherPart1.Domain;

namespace WeatherPart1.OutputFormatter
{
    public interface IOutputFormatter
    {
        IParsedEntity OutputResults();
    }
}