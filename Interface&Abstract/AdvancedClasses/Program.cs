﻿using System;

namespace AdvancedClasses
{
    class Program : IStudent
    {
        static void Main()
        {
            //Customer c1 = new Customer();
            //c1.PrintInfo1();
            //c1.Cal();
            //Program P = new Program();

            //P.Print("Anas");
            //P.Cal(4);
            //((IStudent)P).Cal(9);
            Bird crow = new Bird();
            crow.name = "kråka";
            crow.FoodDigestion();
            crow.Movement();
            ((IAnimal)crow).Movement();
            Frog salmonFrog = new Frog();
            salmonFrog.name = "laxgroda";
            salmonFrog.FoodDigestion();
            ((IAnimal)salmonFrog).FoodDigestion();
            salmonFrog.Movement();
        }

        public void Cal(int num)
        {
            Console.WriteLine(num - 1);
        }

        void IStudent.Cal(int num)
        {
            Console.WriteLine(num*2);
        }

        public void Print(string name)
        {
            Console.WriteLine("Your Name = {0}", name);
        }

        public void PrintInfo()
        {
            Console.WriteLine();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }
    }
}
