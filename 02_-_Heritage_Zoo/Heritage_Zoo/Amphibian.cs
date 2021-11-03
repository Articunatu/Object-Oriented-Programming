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
            base.name = name;
            base.sound = sound;

            jumpHeight = 100;
            species = "Groda";
        }
    }
}