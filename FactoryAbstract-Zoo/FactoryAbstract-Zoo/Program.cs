using System;
namespace ÖvningAbstractFactory
{
    public interface Animal
    {
        public string Speak();
    }
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string Animaltype);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }
    class Cat : Animal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
    class Lion : Animal
    {
        public string Speak()
        {
            return "Roars";
        }
    }
    class Dog : Animal
    {
        public string Speak()
        {
            return "Barks";
        }
    }
    class Octupus : Animal
    {
        public string Speak()
        {
            return "Squawck";
        }
    }
    class Sharp : Animal
    {
        public string Speak()
        {
            return "CantSpeak";
        }
    }
    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Lion"))
            {
                return new Lion();
            }
            else if (Animaltype.Equals("Cat"))
            {
                return new Cat();
            }
            else
            {
                return new Dog();
            }
        }
    }
    class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Octupus"))
            {
                return new Octupus();
            }
            else
            {
                return new Sharp();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            AnimalFactory animalFactory;
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            animal = animalFactory.GetAnimal("Sharp");
            Console.WriteLine("Animal type : " + animal.GetType().Name);
            Console.WriteLine(animal.Speak());
            Console.WriteLine("--------------");
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal type : " + animal.GetType().Name);
            Console.WriteLine(animal.Speak());
        }
    }
}