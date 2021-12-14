using System;

namespace Equals_Tutorial
{
    struct Program
    {
        static void Main()
        {
            //Equalizer();

            //Directions();

            Student s1 = new Student
            {
                FirstName = "Chris",
                LastName = "Brandt"
            };

            Student s2 = new Student
            {
                FirstName = "Chris",
                LastName = "Brandt"
            };

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));


            Console.ReadKey();
        }

        private static void Directions()
        {
            Direction dir1 = Direction.Right;
            Direction dir2 = Direction.Left;
            Direction dir3 = Direction.Up;
            Direction dir4 = Direction.Down;

            Console.WriteLine(dir1.Equals(dir2));
        }

        private static void Equalizer()
        {
            int x = 10, y = 10;
            Console.WriteLine(x == y);
            Console.WriteLine(x.Equals(y));
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Student))
            {
                return false;
            }
            return this.FirstName == ((Student)obj).FirstName && this.LastName == ((Student)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.GetHashCode();
        }
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
}
