using System;

namespace OverrideToString_Tutorial
{
    class Program
    {
        static void Main()
        {
            int number = 10;
            Console.WriteLine(number);

            Student s = new Student();
            s.FirstName = "Chris";
            s.LastName = "Brandt";

            Console.WriteLine(s.ToString());
            //Console.WriteLine(s.Equals(s));

            Console.ReadKey();
        }
    }

    class Student
    {
        private string firstName, lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //public override bool Equals(object obj)
        //{
        //    return this.Equals(obj);
        //}

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
