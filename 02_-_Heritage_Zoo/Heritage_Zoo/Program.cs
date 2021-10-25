using System;

namespace Heritage_Zoo
{
    class Program
    {
        static void Main()
        {
            Bird parrot = new Bird("Jag kan härma läten!", "Pappegoja");
            parrot.length = 5;
            parrot.isVegan = true;
            parrot.wingSize = 4;
            parrot.AnimalInfo();
            Console.WriteLine(parrot.UniqueInfo()+
                 "\n\n"+parrot.MakeSound(parrot.sound));
        }
    }
}