using System;
using System.Collections.Generic;

namespace _04___Collection_Generics
{
    class Program
    {
        static void Main()
        {
            Employee _empo1 = new Employee(101, "Brendan", "Male", 38000);
            Employee _empo2 = new Employee(104, "May", "Female", 43000);
            Employee _empo3 = new Employee(107, "Steven", "Male", 58881);
            Employee _empo4 = new Employee(111, "Anabel", "Female", 49994);
            Employee _empo5 = new Employee(113, "Zinnia", "Female", 75);

            PrintStack(_empo1, _empo2, _empo3, _empo4, _empo5);
            PrintList(_empo1, _empo2, _empo3, _empo4, _empo5);
        }

        static void PrintStack(Employee empo1, Employee empo2, Employee empo3, Employee empo4, Employee empo5)
        {
            Console.WriteLine("\nPART 1 - STACK\n");
            Console.WriteLine("****************************");
            Console.WriteLine("Retrieve using Push Method and Foreach Loop");       

            Stack<Employee> stackedEmployees = new Stack<Employee>();

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

            Employee employee1 = stackedEmployees.Pop();
            employee1.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            Employee employee2 = stackedEmployees.Pop();
            employee2.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            Employee employee3 = stackedEmployees.Pop();
            employee3.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            Employee employee4 = stackedEmployees.Pop();
            employee4.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            Employee employee5 = stackedEmployees.Pop();
            employee5.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            stackedEmployees.Push(empo1);
            stackedEmployees.Push(empo2);
            stackedEmployees.Push(empo3);
            stackedEmployees.Push(empo4);
            stackedEmployees.Push(empo5);

            Console.WriteLine("****************************" +
                "\nRetrieve using Peek Method");

            employee1 = stackedEmployees.Peek();
            employee1.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            employee2 = stackedEmployees.Peek();
            employee2.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            employee3 = stackedEmployees.Peek();
            employee3.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            employee4 = stackedEmployees.Peek();
            employee4.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            employee5 = stackedEmployees.Peek();
            employee5.PrintEmployeeInfo();
            Console.WriteLine("Items left in the stack: " + stackedEmployees.Count);

            Console.WriteLine("****************************");

            string hasThirdEmployee = stackedEmployees.Contains(empo3) ? "Emp3 is in stack" : "Emp3 is NOT in stack";
            Console.WriteLine(hasThirdEmployee);
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

            Console.WriteLine("The first male employee in this list is:");
            Employee firstMaleEmployee = listedEmployees.Find(employee => employee.gender.Equals("Male"));
            firstMaleEmployee.PrintEmployeeInfo2();
            Console.WriteLine("****************************");

            Console.WriteLine("The male employees in this list are:");
            List<Employee> maleEmployees = listedEmployees.FindAll(employee => employee.gender.Equals("Male"));
            foreach (Employee maleEmployee in maleEmployees)
            {
                maleEmployee.PrintEmployeeInfo2();
            }
        }
    }
}