using System;

namespace _03___Polymorphism_Geometry
{
    class Circle : Drawing
    {
        public double Radius { get; set; }

        public Circle()
        {
            GeometryName = "cirkel";
            Radius = 4;
        }

        public override double Area()
        {
            return Math.Round(Radius * 3.14, 2);
        }
    }
}
