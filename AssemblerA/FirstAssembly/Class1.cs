using System;

namespace FirstAssembly
{
    public class Class1FirstAssmebly
    {
        protected internal int ID = 120;
    }

    public class Class2FirstAssmebly
    {
        public void Example()
        {
            Class1FirstAssmebly A1 = new Class1FirstAssmebly();
            Console.WriteLine(A1.ID);
        }         
    }
}
