using System.Collections.Generic;
using System.Linq;
using System;

namespace DictionariesTest
{
    class Program
    {
        static void Main()
        {
            Country china  = new Country("KINA", "Beijing", "KIN");
            Country india  = new Country("INDIEN", "New Dehli", "IND");
            Country usa    = new Country("FÖRENTA STATERNA", "Washington", "USA");
            Country russia = new Country("RYSSLAND", "Moskva", "RYS");
            Country brazil = new Country("BRASILIEN", "Brasíl", "BRA");

            List<Country> countries = new List<Country>();
            countries.Add(china);countries.Add(india);countries.Add(usa);countries.Add(russia);countries.Add(brazil);
            AskUser(countries);

            //PrintDictionary();
            //TGVPrint();      
            //PrintQueue();
        }

        static void AskUser(List<Country> _countries)
        {
            Console.WriteLine("Skriv in en tre-siffrig kod för att hitta ett land:\n");
            string answer = Console.ReadLine();

            Country ansCou = _countries.Find(A => A.code.Contains(answer));
            string validationMessage = (ansCou == null) ? "\nLandskoden är ej giltig.\n" :
                                                          "\nDu har valt " + ansCou.name + "\n";
            Console.WriteLine(validationMessage +
                             "\nVill du skriva in fler länder? Skriv isåfall JA \n");

            string binaryAnswer = Console.ReadLine() + "\n";
            if (binaryAnswer.ToUpper() == "JA") { AskUser(_countries); }
        }

        static void PrintQueue()
        {
            FrontierBrain f1 = new FrontierBrain() { id = 119, name = "Tucker", gender = "Male", salary = 75000 };
            FrontierBrain f2 = new FrontierBrain() { id = 121, name = "Nolan", gender = "Male", salary = 56000 };
            FrontierBrain f3 = new FrontierBrain() { id = 127, name = "Brandon", gender = "Male", salary = 99000 };
            FrontierBrain f4 = new FrontierBrain() { id = 133, name = "Lucy", gender = "Female", salary = 71000 };
            FrontierBrain f5 = new FrontierBrain() { id = 138, name = "Greta", gender = "Female", salary = 62000 };

            Queue<FrontierBrain> FronQue = new Queue<FrontierBrain>();
            FronQue.Enqueue(f1);
            FronQue.Enqueue(f2);
            FronQue.Enqueue(f3);
            FronQue.Enqueue(f4);
            FronQue.Enqueue(f5);

            //FrontierBrain fdq = FronQue.Dequeue();
            //fdq.PrintInfo();
            //Console.WriteLine("Antal ledare i queuen = " + FronQue.Count);

            //FrontierBrain fdq2 = FronQue.Dequeue();
            //fdq2.PrintInfo();
            //Console.WriteLine("Antal ledare i queuen = " + FronQue.Count);

            FrontierBrain pfb1 = FronQue.Peek();
            pfb1.PrintInfo();
            Console.WriteLine("Antal ledare i queuen är: " + FronQue.Count);

            FrontierBrain pfb2 = FronQue.Peek();
            pfb2.PrintInfo();
            Console.WriteLine("Antal ledare i queuen är: " + FronQue.Count +"\n");

            string printContain = FronQue.Contains(f3) ? "Ledaren finns med" : "Ingen ledare vid det namn finns";
            Console.WriteLine(printContain);
        }

        static void TGVPrint()
        {
            FrontierBrain s1 = new FrontierBrain() { id = 119, name = "Tucker", gender = "Male", salary = 75000 };
            FrontierBrain s2 = new FrontierBrain() { id = 121, name = "Nolan", gender = "Male", salary = 56000 };
            FrontierBrain s3 = new FrontierBrain() { id = 127, name = "Brandon", gender = "Male", salary = 99000 };
            FrontierBrain s4 = new FrontierBrain() { id = 133, name = "Lucy", gender = "Female", salary = 71000 };
            FrontierBrain s5 = new FrontierBrain() { id = 138, name = "Greta", gender = "Female", salary = 62000 };

            Dictionary<int, FrontierBrain> frontierBrains = new Dictionary<int, FrontierBrain>();

            frontierBrains.Add(s1.id, s1);
            frontierBrains.Add(s2.id, s2);
            frontierBrains.Add(s3.id, s3);
            frontierBrains.Add(s4.id, s4);
            frontierBrains.Add(s5.id, s5);

            FrontierBrain st;

            if (frontierBrains.TryGetValue(119, out st))
            {
                Console.WriteLine("Ett objekt där id:et är {0} finns ", st.id);
            }
            else
            {
                Console.WriteLine("Ett objekt med det id_et finns ej....");
            }

            //students.Clear();
            Console.WriteLine("Antalet studenter är " + frontierBrains.Count + " stycken.\n");

            foreach (KeyValuePair<int, FrontierBrain> frontierBrain in frontierBrains)
            {
                frontierBrain.Value.PrintInfo();
            }

            ///Overload count
            Console.WriteLine("Frontier Brains som tjänar mer än 70000 är i antal: " + frontierBrains.Count(k => k.Value.salary > 70000));

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
