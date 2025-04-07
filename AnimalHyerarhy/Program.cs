﻿namespace AnimalHyerarhy
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
            Animal[] animals = {new Dog("Vasyl"), new Cat("Frosia"), 
            new Antilopa("Lusia"), new Tiger("Petia"), new Cow("Bilka")};
            for (int i = 0; i < animals.Length; i++)
            {   
                Random random = new Random();
                int randomNumber = random.Next(1, 10); 
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
