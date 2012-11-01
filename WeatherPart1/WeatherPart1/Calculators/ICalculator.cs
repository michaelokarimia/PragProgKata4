using System.Collections.Generic;
using WeatherPart1.Domain;

namespace WeatherPart1.Calculators
{
    public interface ICalculator<T,U> where T : IParsedEntity where U : ICalulatedSum
    {
        U Calculate(List<T> results);
    }
}