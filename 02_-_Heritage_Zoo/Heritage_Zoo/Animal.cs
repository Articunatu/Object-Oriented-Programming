using System;

namespace Heritage_Zoo
{
    class Life
    {
        public int height = 88;
        public string species, name;
    }

    class Animal: Life
    {               // km/h                
        public int velocity, amountOfLegs = 2;
        public string  sound, uniqueInfo = "Unika egenskaper okända", move = "springa";
        public bool isVegan, isWild;

        public Animal()
        {

        }
        
        public virtual string MakeSound(string sound)
        {
            this.sound = sound;
            return "En " + name.ToLower() + " skriker: " + sound.ToUpper();
        }

        public string Movement()
        {
            return $"Den kan {move} med en hastighet på {velocity} km/h.";
        }

        public void AnimalInfo()
        {
            string veganInfo = isVegan ? "Växter" : "Kött";
            Console.WriteLine("Artnamn: " + name +
                            "\nDjurart: " + species +
                            "\nÄter: " + veganInfo +
                            "\nLängd: " + height +" dm" +
                            "\nDen har " + amountOfLegs + " ben"+
                            //"\n" + uniqueInfo +
                            "\n" + Movement() +
                            "\n" + MakeSound(sound));
        }
        
        
    }

    class Plant : Life
    {
        int amountOfLeaves;
        string barkColor, petalColor;

    }
}