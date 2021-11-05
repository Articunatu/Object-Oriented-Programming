using System;


namespace Heritage_Zoo
{
    class Amphibian : Animal
    {
        public string color;
        public bool isToxic;
        public string speciesClass;

        public Amphibian()
        {
            color = "Grönt";
            species = "Groddjur";
            velocity = 10;
        }

        public void InfoSkin()
        {
            Console.WriteLine($"Detta djur har fuktig hud, och har dess skin färgat {color.ToLower()}.");
        }
    }
    class Frog : Amphibian
    {
        public int jumpHeight;

        public Frog(string _name, string _sound)
        {
            base.name = _name;
            base.sound = _sound;
            isToxic = false;
            height = 2;

            jumpHeight = 20; //meter
            speciesClass = "Groda";
        }

        public void InfoJump()
        {
            Console.WriteLine("Gruppering: " + speciesClass + 
                               $"\nDenna groda kan hoppa {jumpHeight} decimeter högt.\n\n");
        }
    }

    class Salamander: Amphibian
    {
        public int tailStrength;

        public Salamander(string _name, string _sound)
        {
            base.name = _name;
            base.sound = _sound;
            color = "Svart med gula prickar";
            isToxic = true;
            isVegan = false;
            height = 4;

            tailStrength = 10;
            speciesClass = "Salamander";
        }

        public void InfoDefense()
        {
            Console.WriteLine("Gruppering: " + speciesClass + 
                              $"\nSalamandern försvarar sig med sin giftiga svans, med en styrka på {tailStrength}.\n\n");
        }

    }
}