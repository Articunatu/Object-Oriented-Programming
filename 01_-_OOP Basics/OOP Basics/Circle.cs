using System;

namespace OOP_Basics
{
    class Circle
    {
        float pi = 3.14f;
        int radius = 0;

        public Circle (int radius)
        {
            this.radius = radius;
        }

        float AreaCalc()
        {           
            return pi * (float)Math.Pow(radius, 2); 
        }                    //Factors the radius by 2

        float VolumeCalc()
        {
            return (4 * pi * (float)Math.Pow(radius, 3)) / 3;
                                  //Factors the radius by 3
        }

        public void CircleInfo()
        {
            Console.WriteLine("Arean av en cirkel med en radie på {2} meter är {0} kvadratmeter, " +
                "\noch volymen av ett klot med samma radie är {1} kubikmeter.\n",
                AreaCalc(), VolumeCalc(), radius);
        }
    }
}
