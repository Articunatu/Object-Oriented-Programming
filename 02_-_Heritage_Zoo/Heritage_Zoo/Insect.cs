using System;

namespace Heritage_Zoo
{
    class Insect : Animal
    {
        public int amountOfWings;
        public Insect(string _name)
        {
            this.name = _name;
            sound = "Bzzzzzz....!";

            velocity = 75;
            amountOfLegs = 6;
            species = "Insekt";
            //uniqueInfo = UniqueInfo();
            amountOfWings = 2;
        }

        public void InfoWingAmount()
        {
            Console.WriteLine($"Denna insekt har {amountOfWings} stycken vingar.\n\n"); 
        }

        public override string MakeSound(string _sound)
        {
            return base.MakeSound(_sound).Replace("skriker", "låter"); //Changes a word in the original method
        }                                                             //in the animal class
    }
}