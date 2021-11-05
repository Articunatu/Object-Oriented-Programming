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
            obj.CowCreator();
            obj.TulpinCreator();
            obj.NormalFrogCreator();
            obj.PoisonArrowFrogCreator();
            obj.FireSalamanderCreator();         
        }

        public void ParrotCreator()
        {
            Bird parrot = new Bird("Pappegoja", "Jag kan härma läten")
            {
                height = 5,
                isVegan = true,
                wingSize = 4
            };            
            parrot.AnimalInfo();
            parrot.InfoWingSize();
        }

        public void SparrowCreator()
        {
            Bird sparrow = new Bird("Sparv", "Fuuii-fuuii")
            {
                wingSize = 1
            };
            sparrow.AnimalInfo();
            sparrow.InfoWingSize();
        }

        public void BeetleCreator()
        {
            Insect beetle = new Insect("Skalbagge")
            {
                amountOfWings = 4,
                move = "flyga"
            };
            beetle.AnimalInfo();
            beetle.InfoWingAmount();
        }

        public void TulpinCreator()
        {
            Plant tulpin = new Plant("Tulpan", "Blomma")
            {
                amountOfLeaves = 2,
                petalColor = "Gul",
                height = 2
            };
            tulpin.PlantInfo();
        }

        public void NormalFrogCreator()
        {
            Frog normalFrog = new Frog("Vanliggroda", "Croak")
            {
           
            };
            normalFrog.AnimalInfo();
            normalFrog.InfoSkin();
            normalFrog.InfoJump();
        }

        public void PoisonArrowFrogCreator()
        {
            Frog poisonArrow = new Frog("Pilgiftsgroda", "Ribbid")
            {
                isToxic = true,
                color = "Lila",
                jumpHeight = 15
            };
            poisonArrow.AnimalInfo();
            poisonArrow.InfoSkin();
            poisonArrow.InfoJump();
        }

        public void FireSalamanderCreator()
        {
            Salamander fireSalamander = new Salamander("Eldsalamander", "Gwou")
            {

            };
            fireSalamander.AnimalInfo();
            fireSalamander.InfoSkin();
            fireSalamander.InfoDefense();
        }

        public void CowCreator()
        {
            Animal cow = new Animal()
            {
                sound = "Muu",
                name = "Ko",
                height = 20,
                isVegan = true,
                velocity = 3,
                species = "Hovdjur"
            };
            cow.AnimalInfo();
        }
    }
}