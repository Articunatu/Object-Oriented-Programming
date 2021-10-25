using System;

namespace OOP_Basics
{
    class Triangle
    {
        int width = 0, height = 0;

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        float AreaCalc()
        {
            return (width * height) / 2;
        }                      

        float VolumeCalc()
        {
            return (AreaCalc() * height) / 3; //Volume for a pyramid with a triangular base
        }

        public void TraingleInfo()
        {
            Console.WriteLine("Arean av en triangel med en bas på {2} meter och en höjd på {3} meter är {0} " +
                "\nkvadratmeter, och volymen av en triangulär pyramid med samma mått är {1} kubikmeter.\n", +                 
                AreaCalc(), VolumeCalc(), width, height);
        }
    }
}
