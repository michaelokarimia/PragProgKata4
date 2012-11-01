using WeatherPart1.Dto;

namespace WeatherPart1.OutputFormatter
{
    public interface IOutputFormatter<T, C> where C: ICalulatedResult 
    {
        T OutputResults(C entity);
    }
}