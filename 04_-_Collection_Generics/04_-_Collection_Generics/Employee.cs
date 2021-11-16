using System;

namespace _04___Collection_Generics
{
    class Employee
    {
        public int id, salary;
        public string name, gender;

        public Employee(int _id, string _name, string _gender, int _salary)
        {
            id = _id;
            name = _name;
            gender = _gender;
            salary = _salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.Write(id + " - " +
                          name + " - " +
                          gender + " " +
                          salary + "\n");
        }

        public void PrintEmployeeInfo2()
        {
            Console.Write($"ID = {id}, Name = {name}, Gender = {gender}, Salary = {salary}\n");
        }
    }
}
