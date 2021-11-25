
namespace TypesOfClasses_Tutorial
{
    class Program
    {
        static void Main()
        {
            PartialExercise();
            SealedExercisePrint();
        }

        private static void PartialExercise()
        {
            System.Console.WriteLine("Partial Class\n");
            PartialCustomer customer1 = new PartialCustomer();
            customer1.FirstName = "Christoffer";
            customer1.LastName = "Brandt";
            customer1.Gender = "Male";
            customer1.ID = 100;
            customer1.Email = "chris.brandt@hotmail.com";
            customer1.Salary = 25000;
            customer1.PrintInfo();
        }

        private static void SealedExercisePrint()
        {
            System.Console.WriteLine("\n----------------------------------\nSealed Class\n");
            C c1 = new C();
            c1.GetInfo();
            c1.TestInfo();
        }
    }
}
