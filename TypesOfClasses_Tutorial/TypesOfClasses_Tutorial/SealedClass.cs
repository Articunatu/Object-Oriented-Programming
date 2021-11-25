using System;

namespace TypesOfClasses_Tutorial
{

    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base class A GetInfo-method");
        }

        public virtual void TestInfo()
        {
            Console.WriteLine("Base class A GetTest-method");
        }
    }

    class B : A
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Child class B GetInfo-method");
        }

        public override void TestInfo()
        {
            Console.WriteLine("Child class B TestInfo-method");
        }
    }

    class C : B
    {
        //public override void GetInfo()
        //{
        //    Console.WriteLine("Child clas C GetInfo-method");
        //}

        public override void TestInfo()
        {
            Console.WriteLine("Child class C TestInfo-method");
        }
    }
}
