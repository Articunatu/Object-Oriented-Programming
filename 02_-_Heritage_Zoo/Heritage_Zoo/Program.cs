using System;

namespace Heritage_Zoo
{
    class Program
    {
        static void Main()
        {
            Program obj = new Program();
            obj.ParrotCreator();
            obj.SparrowCReator();
            obj.BeetleCreator();
        }

        public void ParrotCreator()
        {
            Bird parrot = new Bird("Pappegoja", "Jag kan härma läten!");
            parrot.height = 5;
            parrot.isVegan = true;
            parrot.wingSize = 4;
            parrot.AnimalInfo();
        }

        public void SparrowCReator()
        {
            Bird sparrow = new Bird("Sparv", "FUUII! FUUII!");
            sparrow.wingSize = 1;
            sparrow.AnimalInfo();
        }

        public void BeetleCreator()
        {
            Insect beetle = new Insect("Skalbagge", "Bzzzzzz....!");
            beetle.amountOfWings = 4;
            beetle.AnimalInfo();
        }
    }
}