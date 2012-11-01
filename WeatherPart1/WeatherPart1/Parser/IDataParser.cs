using System.Collections.Generic;
using WeatherPart1.Domain;
using WeatherPart1.Dto;

namespace WeatherPart1.Parser
{
    public interface IDataParser<T> where T : IParsedEntity
    {
        List<T> GetResultList();
    }
}   