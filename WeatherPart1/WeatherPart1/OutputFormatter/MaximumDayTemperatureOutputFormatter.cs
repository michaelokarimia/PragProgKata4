using WeatherPart1.Dto;

namespace WeatherPart1.OutputFormatter
{
    public class MaximumDayTemperatureOutputFormatter : IOutputFormatter<string, MaxDaySpread>
    {
        public string OutputResults(MaxDaySpread daywithMaxDaySpread)
        {
            return string.Format("Maximum Temperature spread was during Day {0}", daywithMaxDaySpread.DayNumber);
        }
    }
}