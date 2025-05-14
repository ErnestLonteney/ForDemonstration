namespace AnimalHyerarhy
{
    internal class Program
    {
        static void Introduce(params Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].IntroduseMyselfe();
            }
        }

        static void Main()
        {
            Cat barsic = new Cat("Barsic")
            {
                CountPaws = 4,
                Nutrition = "Wiskas"
            };


            barsic.Nutrition = "Felix";
            
            Dog dog1 = new Dog("Jack");

            barsic.IntroduseMyselfe();
            dog1.IntroduseMyselfe();


            //barsic.MakeVoice();

            //jack.MakeVoice();

            Console.WriteLine(dog1.Name);


            Introduce();

        }
    }
}
