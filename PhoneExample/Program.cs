namespace PhoneExample
{
    internal class Program
    {
        static void Main()
        {
            var nokia = new ButtonPhone("Nokia", "5900", "black");
            var samsung = new SmartPhone("Intel Core m345", "Samsung", "A72", "Silver");

            var myPhones = new Phone[] { nokia, samsung };

            Guid volodymyrId = nokia.ContactBook.AddContact(new Contact("Volodymyr", "+390832392030"));
            Guid workId = nokia.ContactBook.AddContact(new Contact("Work", "+34454555543"));
            
            nokia.MakeACall(volodymyrId);
            Task.Delay(3000);
            nokia.EndACall(volodymyrId);

            nokia.GetHystoryOfCalls();

            var insuranceContact = new Contact("Insurance company", "+3343434344");
            samsung.ContactBook.AddContact(insuranceContact);
            Guid janeId = samsung.ContactBook.AddContact(new Contact("Jane", "+34545555"));
            
            samsung.MakeACall(janeId);
            Task.Delay(2000);
            samsung.EndACall(janeId);
           
            samsung.MakeACall(insuranceContact.Id);
            Task.Delay(4000);
            samsung.EndACall(insuranceContact.Id);

            samsung.GetHystoryOfCalls();

            for (int i = 0; i < myPhones.Length; i++)
            {
                if (myPhones[i] is IIdentifier)
                    Console.WriteLine($"Client`s id of phone = {((IIdentifier)myPhones[i]).Id}");
            }

        }
    }
}