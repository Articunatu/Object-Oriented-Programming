using System;

namespace TypesOfClasses_Tutorial
{
    class Customer
    {
        private string firstName, lastName, gender;
        private int id, salary;

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
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string FullName()
        {
            return firstName + " " + lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {FullName()}\nID: {id}\nSalary: {salary}\nGender: {gender}");
        }
    }
}
