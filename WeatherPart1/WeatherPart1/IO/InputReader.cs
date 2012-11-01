using System.IO;

namespace WeatherPart1.IO
{
    public class InputReader : IInputReader
    {
        private StreamReader sr;

        public void Dispose()
        {
            sr.Dispose();
        }

        public virtual string ReadLine()
        {
            return sr.ReadLine();
        }

        public InputReader(string validDataFilePath)
        {
            sr = new StreamReader(validDataFilePath);
        }
    }
}