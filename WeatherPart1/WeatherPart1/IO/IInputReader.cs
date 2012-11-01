using System;

namespace WeatherPart1.IO
{
    public interface IInputReader :IDisposable
    {
        string ReadLine();
    }
}