using System.Collections.Generic;
using WeatherPart1.Domain;
using WeatherPart1.Dto;

namespace WeatherPart1.Calculators
{
    public interface ICalculator<T,C> where T : IParsedEntity where C : ICalulatedResult
    {
        C Calculate(List<T> results);
    }
}