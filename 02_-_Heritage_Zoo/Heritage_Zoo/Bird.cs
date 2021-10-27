using System;

namespace Heritage_Zoo
{
    class Bird : Animal
    {              //dm
        public int wingSize = 1;

        //Contructor with default values
        public Bird(string name, string sound)
        {
            base.name = name;
            base.sound = sound;
            move = "flyga";
            velocity = 150;
            height = 2;
            isVegan = false;  
            species = "Fågel";        
            uniqueInfo = UniqueInfo();
        }

        public string UniqueInfo()
        {
            return $"Storleken på dess vingar är {wingSize} dm";
        }
    }
}