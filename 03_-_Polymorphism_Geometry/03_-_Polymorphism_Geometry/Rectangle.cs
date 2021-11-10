namespace _03___Polymorphism_Geometry
{
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
}
