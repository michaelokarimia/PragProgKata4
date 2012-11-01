namespace WeatherPart1.Calculators
{
    public class MaxDaySpreadSum : ICalulatedSum
    {
        public int DayNumber { get; private set; }

        public MaxDaySpreadSum(int dayNumber)
        {
            DayNumber = dayNumber;
        }
    }
}