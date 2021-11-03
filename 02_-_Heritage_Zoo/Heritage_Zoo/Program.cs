namespace Heritage_Zoo
{
    class Program
    {
        static void Main()
        {
            Program obj = new Program();
            obj.ParrotCreator();
            obj.SparrowCreator();
            obj.BeetleCreator();
        }

        public void ParrotCreator()
        {
            Bird parrot = new Bird("Pappegoja", "Jag kan härma läten!")
            {
                height = 5,
                isVegan = true,
                wingSize = 4
            };            
            parrot.AnimalInfo();
            parrot.InfoWings();
        }

        public void SparrowCreator()
        {
            Bird sparrow = new Bird("Sparv", "FUUII! FUUII!")
            {
                wingSize = 1
            };
            sparrow.AnimalInfo();
            sparrow.InfoWings();
        }

        public void BeetleCreator()
        {
            Insect beetle = new Insect("Skalbagge")
            {
                amountOfWings = 4,
                move = "flyga"
            };
            beetle.AnimalInfo();
            beetle.UniqueInfo();
        }
    }
}