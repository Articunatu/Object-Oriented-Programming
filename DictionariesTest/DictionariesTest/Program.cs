using System.Collections.Generic;
using System.Linq;
using System;

namespace DictionariesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //PrintDictionary();
            TGVPrint();           
        }

        static void TGVPrint()
        {
            Student s1 = new Student() { id = 119, name = "Tucker", gender = "Male", salary = 75000 };
            Student s2 = new Student() { id = 121, name = "Nolan", gender = "Male", salary = 56000 };
            Student s3 = new Student() { id = 127, name = "Brandon", gender = "Male", salary = 99000 };
            Student s4 = new Student() { id = 133, name = "Lucy", gender = "Female", salary = 71000 };
            Student s5 = new Student() { id = 138, name = "Greta", gender = "Female", salary = 62000 };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            { };

            students.Add(s1.id, s1);
            students.Add(s2.id, s2);
            students.Add(s3.id, s3);
            students.Add(s4.id, s4);
            students.Add(s5.id, s5);

            Student st;

            if (students.TryGetValue(119, out st))
            {
                Console.WriteLine("Ett objekt där id:et är {0} finns ", st.id);
            }
            else
            {
                Console.WriteLine("Ett objekt med det id_et finns ej....");
            }

            //students.Clear();
            Console.WriteLine("Antalet studenter är " + students.Count + " stycken.\n");

            foreach (KeyValuePair<int, Student> student in students)
            {
                student.Value.PrintInfo();
            }

            ///Array to dictionary
            //Student[] arrayStudents = new Student[5];
            //arrayStudents[0] = s1;
            //arrayStudents[1] = s2;
            //arrayStudents[2] = s3;
            //arrayStudents[3] = s4;
            //arrayStudents[4] = s5;
            //arrayStudents[4] = s5;

            //Dictionary<int, Student> fromArrayToDict = arrayStudents.ToDictionary(s => s.id, s => s);    

            //foreach (KeyValuePair<int,Student > item in fromArrayToDict)
            //{
            //    Console.WriteLine("The key is : " + item.Key);
            //    Student s33 = item.Value;
            //    s33.PrintInfo();
            //}
        }

        static void PrintDictionary()
        {
            Dictionary<int, string> MyDictin = new Dictionary<int, string>();
            MyDictin.Add(1993, "Adam");
            MyDictin.Add(1991, "Juan");
            MyDictin.Add(1994, "Will");

            //string i = MyDictin[4444];
            //string x = MyDictin[8888];

            //Console.WriteLine($"Namn = {i}, Namn = {x}");

            foreach (KeyValuePair<int, string> item in MyDictin)
            {
                Console.WriteLine($"ID = {item.Key}, Namn = {item.Value}");
            }
        }
    }
}
