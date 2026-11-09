namespace MementoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero
            {
                Name = "Aragorn",
                Level = 10,
                Type = TypeHero.Warrior
            };

            var slave = new Slave
            {
                Name = "Gollum"
            };

            hero.Items = ["Sword", "Shield", "Potion", "Scroll"];
            hero.ShowInfo();    
            hero.ShowItems();
            // Save state of hero's items to slave's storage
            slave.StorageBack = hero.PackStorage();
            // Change hero's state by modifying items
            hero.Items = ["Axe", "Helmet"];

            hero.Fight();
            hero.ShowItems();
            // Restore hero's state from slave's storage
            hero.UnpackStorage(slave.StorageBack);
            hero.Fight();
            hero.ShowItems();   
        }
    }
}
