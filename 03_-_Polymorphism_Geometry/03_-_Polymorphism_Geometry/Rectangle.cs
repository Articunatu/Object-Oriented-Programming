using System;

namespace _03___Polymorphism_Geometry
{
    class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            GeometryName = "rektangel";
            Height = 4;
            Width = 5;
        }

        public override double Area()
        {
            return Math.Round(Height * Width, 2);
        }
    }
}
