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

            barsic.IntroduseMyselfe();
            djack.IntroduseMyselfe();


            barsic.MakeVoice();

            djack.MakeVoice();

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
