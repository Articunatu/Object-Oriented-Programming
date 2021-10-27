using System;

namespace Heritage_Zoo
{
    class Life
    {
        public int height = 0;
        public string species, name;
    }

    class Animal: Life
    {               // dm          // km/h
        public int velocity = 0, amountOfLegs;
        public string  sound, uniqueInfo, move;
        public bool isVegan, isWild;
        
        public string MakeSound(string sound)
        {
            this.sound = sound;
            return "En " + name.ToLower() + " skriker: " + sound.ToUpper() + "\n\n";
        }

        public string Movement()
        {
            return "En " + name.ToLower() + " kan "+ move +"  med en hastighet på " + velocity + "km/h.";
        }

        public void AnimalInfo()
        {
            string veganInfo = isVegan ? "Växter" : "Kött";
            Console.WriteLine("Djurart: " + species +
                            "\nArtnamn: " + name +
                            "\nÄter " + veganInfo +
                            "\nLängd: " + height +
                            "\n" + uniqueInfo +
                            "\n" + MakeSound(sound));
        }
    }

    class Plant : Life
    {

    }
}