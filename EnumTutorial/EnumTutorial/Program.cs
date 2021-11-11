using System;

namespace EnumTutorial
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

    class Program
    {
        static void Main()
        {
            Student S1 = new Student() { ID = 201, Name = "Dawn", gender = Gender.Female };
            Student S2 = new Student() { ID = 215, Name = "Volkner", gender = Gender.Male };
            Student S3 = new Student() { ID = 226, Name = "Lucian", gender = Gender.Other };
        }

        static void PrintWeekDays()
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

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
