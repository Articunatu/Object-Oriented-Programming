using System;

namespace Heritage_Zoo
{
    class Life
    {
        public int height = 88;
        public string species, name;
    }

    class Animal : Life
    {               // km/h                
        public int velocity, amountOfLegs = 2;
        public string sound, move = "röra sig framåt";
        public bool isVegan;

        public Animal()
        {

        }

        public virtual string MakeSound(string _sound)
        {
            this.sound = _sound;
            return "En " + name.ToLower() + " skriker: " + _sound.ToUpper() + "!";
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
                            "\nLängd: " + height + " dm" +
                            "\nDen har " + amountOfLegs + " stycken ben" +
                            "\n" + Movement() +
                            "\n" + MakeSound(sound));
        }
    }

    class Plant : Life
    {
        public int amountOfLeaves;
        public string petalColor;

        public Plant(string _name, string _species)
        {
            base.name = _name;
            base.species = _species;
        }

        public void PlantInfo()
        {
            Console.WriteLine("Artnamn: " + name +
                            "\nVäxtart: " + species +
                            "\nLängd: " + height + " dm" +

                            "\nDen har " + amountOfLeaves + " stycken löv" +
                            "\nDess blomblad har färgen " + petalColor.ToLower()+"\n\n");
        }
    }
}