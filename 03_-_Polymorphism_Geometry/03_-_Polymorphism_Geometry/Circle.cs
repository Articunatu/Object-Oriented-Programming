using System;

namespace _03___Polymorphism_Geometry
{
    class Circle : Drawing
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
}
