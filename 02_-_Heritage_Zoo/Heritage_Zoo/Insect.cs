using System;

namespace Heritage_Zoo
{
    class Insect : Animal
    {
        public int amountOfWings;

        public Insect(string name, string sound)
        {
            this.name = name;
            this.sound = sound;

            amountOfLegs = 6;
            species = "Insekt";
        }

        public string UniqueInfo()
        {
            return $"Denna insekt har {amountOfWings} stycken vingar.";
        }
    }
}