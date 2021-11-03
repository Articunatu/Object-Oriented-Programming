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
            base.sound = sound;
            move = "flyga";
            velocity = 150;
            height = 2;
            isVegan = false;  
            species = "Fågel";        
            //uniqueInfo = UniqueInfo();
            wingSize = 1;
        }

        public Bird()
        {

        }

        public void InfoWings()
        {
            Console.WriteLine($"Storleken på dess vingar är {wingSize} cm\n\n");
        }

    }
}