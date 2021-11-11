using System;

namespace EnumTutorial
{
    class Program
    {
        public enum WeekDays
        {
            sunday = 1,
            monday,
            tuesday = 1, 
            wednesday,
            thursday = 2,
            friday,
            saturday
            
        }

        static void Main()
        {
            Console.WriteLine("Day of the week {0} {1}", (int)WeekDays.tuesday, WeekDays.tuesday);
            string[] values = Enum.GetNames(typeof(WeekDays));
            int total = 0;

            foreach (string v in values)
            {
                Console.Write(v + " ");
                total++;
                Console.WriteLine(total);
            }
            //Console.WriteLine("Total value in enum = {0}", total);
            //Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            //short[] i = (short[])Enum.GetValues(typeof(WeekDays));
            //foreach (short item in i)
            //{
            //    Console.WriteLine(item);
            //}

            int[] i = (int[])Enum.GetValues(typeof(WeekDays));
            foreach (int item in i)
            {
                Console.WriteLine(item);
            }
        }
    }
}
