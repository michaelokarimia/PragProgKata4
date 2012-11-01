namespace WeatherPart1.Domain
{
    public class WeatherResult :IResult
    {
        public WeatherResult(int day, decimal maxTemp, decimal minTemp)
        {
            Day = day;
            MaxTemperature = maxTemp;
            MinTemperature = minTemp;
        }

        public WeatherResult() {}

        public int Day { get; private set; }

        public decimal MaxTemperature { get; private set; }

        public decimal MinTemperature { get; private set; }
    }
}