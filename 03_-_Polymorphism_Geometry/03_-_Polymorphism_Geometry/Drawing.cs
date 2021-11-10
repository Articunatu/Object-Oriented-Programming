using System;

namespace _03___Polymorphism_Geometry
{
    class Drawing
    {
        public string geoName { get; set; }
        public virtual double Area()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Denna {geoName} har en area på {Area()} kvadratcentimeter.\n");
        }
    }

    class Circle: Drawing
    {
        public double radius { get; set; }

        public Circle()
        {
            geoName = "cirkel";
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
            geoName = "rektangel";
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
            geoName = "triangel";
            height = 7;
            triBase = 3;
        }

        public override double Area()
        {
            return Math.Round((height * triBase)/2);
        }
    }
}
