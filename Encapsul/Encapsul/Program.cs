using System;

namespace Encapsul
{
    class Program
    {
        static void Main()
        {
            Customer custom = new Customer("chris.brandt@", "Chris", "Brandt", 4);

            custom.PrintInfo();
            Customer cus2 = new Customer();
            cus2.ID = -7;
            cus2.PrintInfo();
        }
    }
}
