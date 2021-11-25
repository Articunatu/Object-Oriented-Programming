using System;

namespace TypesOfClasses_Tutorial
{
    public partial class PartialEmployee
    {
        public void PrintFullName()
        {
            Console.WriteLine("Full name is: {0} {1}", firstName, lastName);
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("Employee details: ");
            Console.WriteLine("Fisrt name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Salary: {0}", salary);
        }
    }
}
