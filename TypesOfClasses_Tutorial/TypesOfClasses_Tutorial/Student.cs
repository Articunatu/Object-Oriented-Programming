
namespace TypesOfClasses_Tutorial
{
    class Student
    {
        private string firstName, lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }

    //private static void OldInfo()
    //{
    //    Detailes d = new Detailes();
    //    d.GetAge();
    //    User u = new User();
    //    u.GetInfo();
    //    PrintStudent();
    //    PrintEmployee();
    //    C c = new C();
    //    c.TestInfo();
    //    Console.ReadKey();
    //}

    //static void PrintStudent()
    //{
    //    Student S1 = new Student();
    //    S1.FirstName = "Lelouch";
    //    S1.LastName = "Vi Britannia";
    //    string fN = S1.GetFullName();
    //    Console.WriteLine(fN);

    //    Console.WriteLine("----------------------");

    //    Console.WriteLine("Partial Class");

    //    PartialStudent S2 = new PartialStudent();
    //    S2.FirstName = "Light";
    //    S2.LastName = "Yagami";
    //    string fN2 = S2.GetFullName();
    //    Console.WriteLine("Partial class full name: " + fN2);

    //}

    //static void PrintEmployee()
    //{
    //    Employee E1 = new Employee();
    //    E1.FirstName = "Kallen";
    //    E1.LastName = "Kozuki";
    //    E1.Salary = 3000;
    //    E1.Gender = "Female";
    //    E1.PrintFullName();
    //    Console.WriteLine("--------------");
    //    E1.EmployeeDetails();

    //    Console.WriteLine("-----------\nPartial");

    //    PartialEmployee E2 = new PartialEmployee();
    //    E2.FirstName = "Suzaku";
    //    E2.LastName = "Kururugi";
    //    E2.Salary = 200;
    //    E2.Gender = "Male";
    //    E2.PrintFullName();
    //    Console.WriteLine("--------------");
    //    E2.EmployeeDetails();
    //}

    //sealed class User
    //{
    //    public string name = "Annie", location = "Eldia";

    //    public void GetInfo()
    //    {
    //        Console.WriteLine("Name : {0}", name);
    //        Console.WriteLine("Location: {0}", location);
    //    }
    //}

    //public class Detailes //: User
    //{
    //    public int age = 26;

    //    public void GetAge()
    //    {
    //        Console.WriteLine("Age : {0}", age);
    //    }
    //}
}
