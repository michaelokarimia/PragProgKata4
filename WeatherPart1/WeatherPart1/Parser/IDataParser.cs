using System.Collections.Generic;
using WeatherPart1.Domain;

namespace WeatherPart1.Parser
{
    public interface IDataParser
    {
         List<WeatherResult> GetResultList();
    }
}   