using System;


namespace Heritage_Zoo
{
    class Amphibian : Animal
    {
        public string color;

        public Amphibian()
        {
            color = "Grön";
        }
    }
    class Frog : Amphibian
    {
        public int jumpHeight;

        public Frog(string name, string sound)
        {
            this.name = name;
            this.sound = sound;

            jumpHeight = 100;
            species = "Groda";
        }
    }
}