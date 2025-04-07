namespace AnimalHyerarhy
{
    internal class Program
    {
        static void Main()
        {
            Cat barsic = new Cat("Barsic")
            {
                CountPaws = 4,
                Nutrition = "Wiskas"
            };

            barsic.Nutrition = "Felix";
            
            Dog djack = new Dog("Djack");

            //barsic.IntroduseMyselfe();
            //djack.IntroduseMyselfe();


           // barsic.MakeVoice();

           // djack.MakeVoice();

            Animal[] animals = new Animal[5];
            animals[0] = new Dog("Vasyl");
            animals[1] = new Cat("Frosia");
            animals[2] = new Antilopa("Lusia");
            animals[3] = new Tiger("Petia");
            animals[4] = new Cow("Bilka");

            for (int i = 0; i < animals.Length; i++)
            {   
                Random random = new Random();
 
                int min = 1;
                int max = 10;
                int randomNumber = random.Next(min, max); 
                for (int j = 0; j < randomNumber; j++)
                    {
                        animals[i].MakeVoice();
                    }
            }
        }
        public void Introduce(Animal[] animals)
        {
        for (int i = 0; i == animals.Length-1; i++)
        {
            animals[i].IntroduseMyselfe();
        if (animals[i] is Predator)
        {
                    Predator predator = (Predator) animals[i];
                    predator.Hunt();
        }
         else if (animals[i] is Herbivore)
        {
                    Herbivore herbivore = (Herbivore) animals[i];
                    herbivore.Herd();
        }
        }
        }
    }
}
