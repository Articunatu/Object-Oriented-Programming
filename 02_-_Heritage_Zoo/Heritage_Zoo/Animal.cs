using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Zoo
{
    class Animal
    {               // dm          // km/h
        public int length = 0, velocity = 0;
        public string species, name, sound;
        public bool isVegan;
        
        public string MakeSound(string newSound)
        {
            sound = newSound;
            return "En " + name.ToLower() + " skriker: " + sound.ToUpper();
        }
        public void AnimalInfo()
        {
            Console.WriteLine("Djurart: " + species +
                            "\nArtnamn: " + name +
                            "\nHastighet: " + velocity +
                            "\nLängd: " + length);
        }
    }
}