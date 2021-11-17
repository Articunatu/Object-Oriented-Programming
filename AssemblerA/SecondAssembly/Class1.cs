using System;
using FirstAssembly;

namespace SecondAssembly
{
    public class Class1 : Class1FirstAssmebly
    {
        public void Exec()
        {
            Class1FirstAssmebly C1 = new Class1FirstAssmebly();

            base.ID = 228;

            Class1 class1 = new Class1();
            class1.ID = 225;
        }
    }
}
