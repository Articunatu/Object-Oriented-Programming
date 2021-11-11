namespace _03___Polymorphism_Geometry
{
    class Program
    {
        static void Main()
        {
            Circle circ1 = new Circle() 
            { 
                Radius = 12
            };
            circ1.PrintInfo();

            Rectangle rect1 = new Rectangle()
            {
                Height = 7,
                Width = 8
            };
            rect1.PrintInfo();

            Triangle tri1 = new Triangle();
            tri1.PrintInfo();
        }
    }
}
