using System;

namespace Heritage_Zoo
{
    class Bird : Animal
    {
        public int wingSize = 0;

        //Contructor with default values
        public Bird(string newSound, string newName)
        {
            velocity = 150;
            length = 2;
            isVegan = false;
            name = newName;
            sound = newSound;
            species = "Fågel";
        }

        public string UniqueInfo()
        {
            return $"Storleken på dess vingar är {wingSize} cm";
        }
    }
}