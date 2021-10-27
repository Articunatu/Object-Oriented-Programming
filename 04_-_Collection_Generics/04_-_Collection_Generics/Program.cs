using System;
using System.Collections;
using System.Collections.Generic;

namespace _04___Collection_Generics
{
    class Program
    {
        static void Main()
        {
            PrintStack();         
        }

        static void PrintStack()
        {
            Console.WriteLine("\nPART 1 - STACK\n");
            Console.WriteLine("****************************");

            Employee empo1 = new Employee(101, "Brendan", "Male", 38000);
            Employee empo2 = new Employee(104, "May", "Female", 43000);
            Employee empo3 = new Employee(107, "Steven", "Male", 58881);
            Employee empo4 = new Employee(111, "Anabel", "Female", 49994);
            Employee empo5 = new Employee(113, "Zinnia", "Female", 75);

            Stack stackedEmployees = new Stack();

            stackedEmployees.Push(empo1);
            stackedEmployees.Push(empo2);
            stackedEmployees.Push(empo3);
            stackedEmployees.Push(empo4);
            stackedEmployees.Push(empo5);

            foreach (Employee employee in stackedEmployees)
            {
                employee.PrintEmployeeInfo();
                Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);
            }

            Console.WriteLine("****************************" +
                "\nRetrieve using Pop Method");

            Stack backupEmployees = new Stack();
            foreach (Employee employee in stackedEmployees)
            {
                backupEmployees.Push(employee);
            }

            foreach (Employee employee in stackedEmployees)
            {
                employee.PrintEmployeeInfo();
                backupEmployees.Pop();
                Console.WriteLine("Items left in the stack: " + backupEmployees.Count);
            }

            foreach (Employee employee in backupEmployees)
            {
                stackedEmployees.Push(employee);
            }

            Console.WriteLine("****************************" +
                "\nRetrieve using Peek Method");

            foreach (Employee employee in stackedEmployees)
            {
                employee.PrintEmployeeInfo();
                stackedEmployees.Peek();
                Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);
            }

            Console.WriteLine("****************************");

            string hasThirdEmployee = stackedEmployees.Contains(empo3) ? "Emp3 is in stack" : "Emp3 is NO in stack";
            Console.WriteLine(hasThirdEmployee);

            PrintList(empo1, empo2, empo3, empo4, empo5);
        }

        static void PrintList(Employee empo1, Employee empo2, Employee empo3, Employee empo4, Employee empo5)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("\nPART 2 - LIST\n");
            Console.WriteLine("****************************");

            List<Employee> listedEmployees = new List<Employee>();
            listedEmployees.Add(empo1);
            listedEmployees.Add(empo2);
            listedEmployees.Add(empo3);
            listedEmployees.Add(empo4);
            listedEmployees.Add(empo5);

            string hasEmpo2 = listedEmployees.Contains(empo2) ? "Employee2 object exists in the list" :
                                                                "Employee2 object doesn't exist in the list";
            Console.WriteLine(hasEmpo2);
            Console.WriteLine("****************************");

            Console.WriteLine("The first male employee in the list is:");
            Employee firstMaleEmployee = listedEmployees.Find(A => A.gender.Equals("Male"));
            firstMaleEmployee.PrintEmployeeInfo();
            Console.WriteLine("****************************");

            Console.WriteLine("The  male employees in the list are:");
            List<Employee> maleEmployees = listedEmployees.FindAll(A => A.gender.Equals("Male"));
            foreach (Employee maleEmployee in maleEmployees)
            {
                maleEmployee.PrintEmployeeInfo();
            }
        }
    }
}