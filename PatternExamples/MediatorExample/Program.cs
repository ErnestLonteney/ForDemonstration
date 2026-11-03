namespace MediatorExample
{
    internal class Program
    {
        static async Task Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var ketchupMediator = new KetchupMediator();    

            var fermer1 = new Fermer(ketchupMediator);
            var distributor1 = new Distributor(ketchupMediator);
            var plant1 = new Plant(ketchupMediator);

            ketchupMediator.SetContagents(fermer1, distributor1, plant1);


            await distributor1.Run(); 



        }
    }
}
