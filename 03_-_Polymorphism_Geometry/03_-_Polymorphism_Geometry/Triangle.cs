using System;

namespace _03___Polymorphism_Geometry
{
    class Triangle : Drawing
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
            return Math.Round((height * triBase) / 2);
        }
    }
}
