using System;

namespace _03___Polymorphism_Geometry
{
    class Drawing
    {
        public string geometryName { get; set; }
        public virtual double Area()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Denna {geometryName} har en area på {Area()} kvadratcentimeter.\n");
        }
    }
}
