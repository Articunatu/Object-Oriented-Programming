using System;

namespace Heritage_Zoo
{
    class Insect : Animal
    {
        public int amountOfWings = 2;

        public Insect(string name)
        {
            this.name = name;
            sound = "Bzzzzzz....!";

            amountOfLegs = 6;
            species = "Insekt";
            uniqueInfo = UniqueInfo();
        }

        public string UniqueInfo()
        {
            return $"Denna insekt har {amountOfWings} stycken vingar.";
        }

        public override string MakeSound(string sound)
        {
            return base.MakeSound(sound).Replace("skriker", "låter");
        }
    }
}