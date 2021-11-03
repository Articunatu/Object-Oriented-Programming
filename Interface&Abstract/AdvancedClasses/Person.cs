using System;


namespace AdvancedClasses
{
    public abstract class Person
    {
        public abstract void PrintInfo1();
        public abstract void PrintInfo2();
        public abstract void PrintInfo3();


        public void Cal()
        {
            Console.WriteLine("Calling from the void");
        }

        public void printSalary()
        {
            Console.WriteLine("205588996");
        }

    }

    public class Customer : Person
    {
        public override void PrintInfo1()
        {
            Console.WriteLine("Hello from Print info 1");
        }

        public override void PrintInfo2()
        {
            Console.WriteLine("Hello From Print info 2");
        }

        public override void PrintInfo3()
        {
            throw new NotImplementedException();
        }
    }

    public class Master : Person
    {
        public override void PrintInfo1()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo2()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo3()
        {
            throw new NotImplementedException();
        }
    }
}
