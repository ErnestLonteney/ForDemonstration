namespace PhoneExample
{
    internal class Program
    {
        static void Main()
        {
            var nokia = new ButtonPhone("Nokia", "5900", "black");
            var samsung = new SmartPhone("Intel Core m345", "Samsung", "A72", "Silver");

            var myPhones = new Phone[] { nokia, samsung };

            nokia.AddContact("Volodymyr");
            nokia.AddContact("Work");
            nokia.MakeACall("Work");

            samsung.AddContact("Insurance company");
            samsung.AddContact("Jane");
            samsung.MakeACall("jane");

            for (int i = 0; i < myPhones.Length; i++)
            {
                if (myPhones[i] is IIdentifier)
                    Console.WriteLine($"Client`s id of phone = {((IIdentifier)myPhones[i]).Id}");
            }

        }
    }
}