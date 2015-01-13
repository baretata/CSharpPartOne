using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime start = DateTime.Parse("1:00 AM");
        DateTime end = DateTime.Parse("3:00 PM");
        DateTime time;

        string date = Console.ReadLine();
        if (DateTime.TryParseExact(date, "hh:mm tt", enUS, DateTimeStyles.None, out time))
        {
            if (time > start || time < end)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("not-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
