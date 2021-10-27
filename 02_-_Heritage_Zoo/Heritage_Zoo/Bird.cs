using System;

namespace Heritage_Zoo
{
    class Bird : Animal
    {              //dm
        public int wingSize;

        //Contructor with default values
        public Bird(string name, string sound)
        {
            base.name = name;
            this.sound = sound;
            move = "flyga";
            velocity = 150;
            height = 2;
            isVegan = false;  
            species = "Fågel";
            amountOfLegs = 2;
            wingSize = 1;
            uniqueInfo = UniqueInfo();
        }

        public string UniqueInfo()
        {
            return $"Storleken på dess vingar är {wingSize} dm";
        }
    }
}