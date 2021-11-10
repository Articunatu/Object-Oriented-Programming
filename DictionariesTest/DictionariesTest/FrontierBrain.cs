using System;

namespace DictionariesTest
{
    class FrontierBrain
    {

        public int id { get; set; }
        public int salary { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Namn: "+ name + "\nID: " + id + "\nKön: " + gender + "\nLön: " + salary + "\n");
            
        }
    }
}
