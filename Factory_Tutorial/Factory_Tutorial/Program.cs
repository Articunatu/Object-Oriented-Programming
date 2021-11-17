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

    public interface IProduct
    {
        string Opreation();
    }

    class ConcreteProudct1 : IProduct
    {
        public string Opreation()
        {
            return "Result of first const";
        }
    }

    class ConcreteProudct2 : IProduct
    {
        public string Opreation()
        {
            return "Result of second const";
        }
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOpeneer()
        {
            var prod = FactoryMethod();

            var res = "Creator: The same creator code has just worked with " + prod.Opreation();

            return res;
        }
    }

    class ConcreteCreator1: Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProudct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProudct2();
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App : Launched with the ConcreteCreator 1");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("App : Launched with the ConcreteCreator 2");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator cr)
        {
            Console.WriteLine("Client: I'm now aware of the creator class, but I still work.\n" + cr.SomeOpeneer());
        }
    }

    class Program
    {
        static void Main()
        {
            new Client().Main();
            //PrintVehicle();
        }

        private static void PrintVehicle()
        {
            Console.WriteLine("Enter number of wheels:");

            var wheels = Console.ReadLine();

            var vehicle = VehicleFactory.Build(Convert.ToInt32(wheels));

            Console.WriteLine($"You built a {vehicle.GetType().Name}!");

            Console.ReadKey();
        }
    }
}