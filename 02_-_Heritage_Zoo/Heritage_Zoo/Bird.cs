using System;

namespace Heritage_Zoo
{
    class Bird : Animal
    {              //dm
        public int wingSize;

        //Contructor with default values
        public Bird(string _name, string _sound)
        {
            base.name = _name;
            base.sound = _sound;
            move = "flyga";
            velocity = 150;
            height = 2;
            isVegan = false;  
            species = "Fågel";        
            //uniqueInfo = UniqueInfo();
            wingSize = 1;
        }

        public void InfoWingSize()
        {
            Console.WriteLine($"Storleken på dess vingar är {wingSize} cm\n\n");
        }

    }
}