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

    class Circle: Drawing
    {
        public double radius { get; set; }

        public Circle()
        {
            geometryName = "cirkel";
            radius = 4;
        }

        public override double Area()
        {
            return Math.Round(radius * 3.14, 2);
        }
    }
    class Rectangle : Drawing
    {
        public double height { get; set; }
        public double witdth { get; set; }

        public Rectangle()
        {
            geometryName = "rektangel";
            height = 4;
            witdth = 5;
        }

        public override double Area()
        {
            return height * witdth;
        }
    }

    class Triangle: Drawing
    {
        public double triBase { get; set; }
        public double height { get; set; }

        public Triangle()
        {
            geometryName = "triangel";
            height = 7;
            triBase = 3;
        }

        public override double Area()
        {
            return Math.Round((height * triBase)/2);
        }
    }
}
