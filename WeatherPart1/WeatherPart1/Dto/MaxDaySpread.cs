namespace WeatherPart1.Dto
{
    public class MaxDaySpread : ICalulatedResult
    {
        public int DayNumber { get; private set; }

        public MaxDaySpread(int dayNumber)
        {
            DayNumber = dayNumber;
        }
    }
}