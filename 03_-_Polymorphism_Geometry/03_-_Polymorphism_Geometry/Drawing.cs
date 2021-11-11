using System;

namespace _03___Polymorphism_Geometry
{
    class Drawing
    {
        public string GeometryName { get; set; }
        public virtual double Area()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Denna {GeometryName} har en area på {Area()} kvadratcentimeter.\n");
        }
    }
}
