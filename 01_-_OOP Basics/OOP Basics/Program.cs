namespace OOP_Basics
{
    class Program
    {
        static void Main()
        {
            Circle circle5 = new Circle(5);
            Circle circle6 = new Circle(6);

            circle5.CircleInfo();
            circle6.CircleInfo();

            Triangle triangleEven = new Triangle(4, 4);
            Triangle triangleOdd = new Triangle(7, 11);

            triangleEven.TraingleInfo();
            triangleOdd.TraingleInfo();
        }
    }
}
