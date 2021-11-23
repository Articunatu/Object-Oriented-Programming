using System;

namespace _05___Generic_Class
{
    class Program
    {
        static void Main()
        {
            TVSeries<string> twoSeasons = new TVSeries<string>();
            bool isTV = twoSeasons.ToCheck("TV", "Series");
            Console.WriteLine(isTV);

            TVSeries<int> oneSeason = new TVSeries<int>();
            bool isSameNumber = oneSeason.ToCheck(111, 111);
            Console.WriteLine(isSameNumber);

            Film<string> overOneHour = new Film<string>();
            bool isCinema = overOneHour.ToCheck("Cinema", "Cinema");
            Console.WriteLine(isCinema);

            Film<int> overTwoHours = new Film<int>();
            bool isSameRelease = overTwoHours.ToCheck(1975, 1976);
            Console.WriteLine(isSameRelease);
        }
    }
}