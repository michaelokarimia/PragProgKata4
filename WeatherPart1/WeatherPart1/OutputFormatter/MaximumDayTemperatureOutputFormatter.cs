using WeatherPart1.Dto;

namespace WeatherPart1.OutputFormatter
{
    public class MaximumDayTemperatureOutputFormatter : IOutputFormatter<string>
    {
        private readonly MaxDaySpread daywithMaxDaySpread;

        public MaximumDayTemperatureOutputFormatter(MaxDaySpread daywithMaxDaySpread)
        {
            this.daywithMaxDaySpread = daywithMaxDaySpread;
        }

        public string OutputResults()
        {
            return string.Format("Maximum Temperature spread was during Day {0}", daywithMaxDaySpread.DayNumber);
        }
    }
}