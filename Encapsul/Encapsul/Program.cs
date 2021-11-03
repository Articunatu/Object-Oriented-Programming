using System;

namespace Encapsul
{
    class Program
    {
        static void Main()
        {
            Customer custom = new Customer();
            custom.EMail = "chris.brandt@";
            custom.FirstName = "Chris";
            custom.LastName = "Brandt";
            custom.ID = 4;
            custom.PrintInfo();

            Customer cus2 = new Customer();
            cus2.PrintInfo();

        }
    }
}
