using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Polymorphism_Geometry
{
    class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    class Circle: Drawing
    {
        public double radius { get; set; }

        public Circle()
        {
            radius = 4;
        }

        public override double Area()
        {
            return radius * 3.14;
        }
    }
    class Rectangle : Drawing
    {
        public double height { get; set; }
        public double witdth { get; set; }

        public Rectangle()
        {
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
            height = 7;
            triBase = 3;
        }

        public override double Area()
        {
            return (height * triBase)/2;
        }
    }
}
