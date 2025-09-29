namespace CoAndContrVariants
{
    internal class Program 
    {
        static void GetInfo(Animal animal)
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.Kind);
        }

        static Cat GetAnimal()
        {
            return new Cat("New cat");
        }

        static void Main()
        {         
            Cat cat = new Cat("Lapyk");
            Animal animal = cat;
            IVoice cat2 = new Cat("Bisquit");

            GetInfo(cat);
            GetInfo(animal);
          //  GetInfo(cat2);

            Cat[] cats = [cat, (Cat)cat2, new Cat("Sapfir")];
           
            // co-variants of arrays 
            Animal[] animals = cats;

            // co-variants of delegates
            CatFilter<Animal> filter = new CatFilter<Cat>(GetAnimal);
            Animal animal3 = filter.Invoke();
            
            // contrvariants of delegate
            CatFinder<Cat> finder = new CatFinder<Animal>(GetInfo);
            finder.Invoke(cat);


            // co-variant and contrvariant of interfaces 
            IFactory<Animal, Circle> user1 = new User<Cat, Shape>();
            Animal animal5 = user1.GetInstance();
            string info = user1.GetInfo(new Circle());
            Console.WriteLine(info);
        }
    }
}
