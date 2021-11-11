using System;

namespace _03___Polymorphism_Geometry
{
    class Triangle : Drawing
    {
        public double TriBase { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            GeometryName = "triangel";
            Height = 7;
            TriBase = 3;
        }

        public override double Area()
        {
            return Math.Round((Height * TriBase) / 2, 2);
        }
    }
}
