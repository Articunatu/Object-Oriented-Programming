using System;

namespace Factory_Tutorial
{
    public interface IVehicle
    {

    }

    public class Car : IVehicle
    {

    }

    class Truck : IVehicle
    {

    }

    public class Motorbike : IVehicle
    {

    }

    public class Unicycle : IVehicle
    {

    }

    public static class VehicleFactory
    {
        public static IVehicle Build(int _numberOfWheels)
        {
            switch (_numberOfWheels)
            {
                case 1: return new Unicycle(); 
                case 2: 
                case 3: return new Motorbike();
                case 4: return new Car();
                default: return new Truck();                
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number of wheels:");

            var wheels = Console.ReadLine();

            var vehicle = VehicleFactory.Build(Convert.ToInt32(wheels));

            Console.WriteLine($"You built a {vehicle.GetType().Name}!");

            Console.ReadKey();
        }
    }
}
