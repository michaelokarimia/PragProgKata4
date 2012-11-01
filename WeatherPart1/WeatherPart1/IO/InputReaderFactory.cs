namespace WeatherPart1.IO
{
    public class InputReaderFactory
    {
        public virtual IInputReader GetReader(string validDataFilePath)
        {
            return new InputReader(validDataFilePath);
        }
    }
}