using System;
using System.Text;

namespace StringBuilder_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "C#"; //System.String immutable
            userString += " Video";
            userString += " tutorial";
            userString += " for";
            userString += " beginners";
            Console.WriteLine(userString);

            StringBuilder userBuild = new StringBuilder("C#"); //StringBuilder mutable

            userBuild.Append(" Video");
            userBuild.Append(" tutorial");
            userBuild.Append(" for");
            userBuild.Append(" beginners");
            Console.WriteLine(userBuild);

            StringBuilder sbA = new StringBuilder("Hey, listen!");
            sbA.Insert(4, " Link");
            Console.WriteLine(sbA);

            StringBuilder sbB = new StringBuilder("Your total amount is: ");
            sbB.AppendFormat("{0:C}", 25);
            Console.WriteLine(sbB);

            StringBuilder sbC = new StringBuilder("Hello World");
            sbC.Replace("World", "C#");
            Console.WriteLine(sbC);

            StringBuilder sbD = new StringBuilder("Hello World !!");
            sbD.Remove(6, 6);
            Console.WriteLine(sbD);

            StringBuilder sbE = new StringBuilder("Hello World string");
            string savedString = sbE.ToString();
            Console.WriteLine(savedString);

            StringBuilder sbF = new StringBuilder("Hello world from loop !!!");
            for (int i = 0; i < sbF.Length; i++)
            {
                Console.Write(sbF[i]); //Works because a String is an array of chars
            }
        }
    }
}
