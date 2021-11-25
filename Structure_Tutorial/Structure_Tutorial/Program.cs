using System;

namespace Structure_Tutorial
{
    class Program
    {
        static void Main()
        {
            Student S1 = new Student();
            S1.ID = 401;
            S1.Name = "Serena";
            S1.PrintInfo();

            Student S2 = new Student();
            S2.ID = 403;
            S2.Name = "Calem";
            S2.PrintInfo();
        }
    }

    public struct Student
    {
        private int id;
        private string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }


        public Student(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}", this.id, this.name);
        }
    }

    class Customer
    {
        
    }
}
