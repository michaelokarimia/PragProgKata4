using System.Collections.Generic;
using WeatherPart1.Domain;

namespace WeatherPart1.Calculators
{
    public interface ICalculator<T> where T : IParsedEntity 
    {
        List<ICalulatedSum> Calculate(List<WeatherParsedEntity> results);
    }
}