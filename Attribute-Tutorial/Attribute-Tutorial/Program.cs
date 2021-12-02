using System;
using System.Collections.Generic;
using static Attribute_Tutorial.Calculator;

namespace Attribute_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Addition(8, 8);
            //Calculator.Addition(8, 8, 8);
            //Console.WriteLine(Calculator.Addition(new List<int> { 8, 8, 8, 8 }));

            Console.WriteLine("DELEGATE");

            Calculator c = new Calculator();

            ExDelegate dlg = c.Multi;
            dlg += c.Sub;
            dlg(13, 19);

            //ExDelegate dlg2 = c.Sub;
            //dlg2(57, 19);

            Console.ReadKey();
        }
    }

    class Calculator
    {
        [Obsolete("Use the addition method with a list instead!")]
        public static int Addition(int term1, int term2)
        {
            return term1 + term2;
        }

        [Obsolete("Don't use this old method", true)]
        public static int Addition(int term1, int term2, int term3)
        {
            return term1 + term2 + term3;
        }

        public static int Addition(List<int> terms)
        {
            int sum = 0;
            foreach (int term in terms)
            {
                sum += term;
            }
            return sum;
        }

        public delegate void ExDelegate(int term1, int term2);
        public void Sub(int term1, int term2)
        {
            Console.WriteLine("Difference: {0}", term1 - term2);
        }

        public void Multi(int fact1, int fact2)
        {
            Console.WriteLine("Product: {0}", fact1*fact2);
        }
    }
}