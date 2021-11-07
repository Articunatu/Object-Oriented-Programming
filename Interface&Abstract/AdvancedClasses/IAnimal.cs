using System;

namespace AdvancedClasses
{
    interface IAnimal
    {
        void Movement();
        void FoodDigestion();

        int length { get; set; }
        string name { get; set; }
    }

    public class Bird : IAnimal
    {
        public int length { get ; set ; }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IAnimal.FoodDigestion()
        {

        }

        public void FoodDigestion()
        {
            Console.WriteLine($"Denna {name} äter frön och nötter");
        }

        public void Movement()
        {
            Console.WriteLine($"Denna {name} förflyttar sig genom att flyga");
        }

        void IAnimal.Movement()
        {
            Console.WriteLine(", med en höjd på 40 meter ovanför marken.");
        }
    }
    public class Frog : IAnimal
    {
        public int length { get; set; }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

        public void FoodDigestion()
        {
            Console.WriteLine($"Denna {name} äter främst flugor");
        }

        void IAnimal.FoodDigestion()
        {
            Console.WriteLine(", men även andra insekter");
        }

        public void Movement()
        {
            Console.WriteLine($"Denna {name} förflyttar sig genom att hoppa");
        }
    }
}
