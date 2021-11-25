using System;

namespace TypesOfClasses_Tutorial
{
    class Employee
    {
        private string firstName, lastName, gender;
        private double salary;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name is: {0} {1}", firstName, lastName);
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("Employee details: ");
            Console.WriteLine("Fisrt name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Gender: {0}" , gender);
            Console.WriteLine("Salary: {0}", salary);
        }
    }
}
