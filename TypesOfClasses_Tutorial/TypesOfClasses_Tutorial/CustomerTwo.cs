using System;

namespace TypesOfClasses_Tutorial
{
    public partial class PartialCustomer
    {
        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {FullName()}\nID: {ID}\nSalary: {Salary}\nGender: {Gender}\nEmail: {Email}");
        }
    }
}
