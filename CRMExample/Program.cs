namespace CRMExample
{
    internal class Program
    {
        static void Main()
        {
            var microsoft = new Account("Microsoft")
            {
                ContactInfo =
                [
                    new ContactInfo(4, "Phone", "+13243245435"),
                    new ContactInfo(4, "Phone", "+13243245435")
                ]
            };

            Contact[] contatcs = 
                [
                    new Contact("Jon", "Nikolson", Status.Simple)
                    {
                       Description = "New suppler",
                       Info = 
                       [ 
                           new ContactInfo(0, "Email", "jon@mail.com"),
                           new ContactInfo(1, "Phone", "+3890344342")
                       ],
                       Address = new()
                       {
                           Id = 0,
                           Country = "Ukraine",
                           Street = "Shevchenko",
                           BuildingNumber = "14",
                           Additional = "B"
                       },
                       Account = microsoft
                    },
                    new Contact("Joan", "Peterson", Status.VIP)
                    {
                       Description = "Strategy consultant",
                       Info =
                       [
                           new ContactInfo(2, "Email", "joan@mail.com"),
                           new ContactInfo(3, "Phone", "+5676576")
                       ],
                       Address = new()
                       {
                           Id = 0,
                           Country = "Ukraine",
                           Street = "Kotlarvskogo",
                           BuildingNumber = "18",
                           Additional = "A"
                       },
                       Account = microsoft
                    }

                ];

            microsoft.Contacts = contatcs;


            for (int i = 0; i < contatcs.Length; i++)
            {
                Console.WriteLine(contatcs[i].GetMyInfo());
                Console.WriteLine(new string('-', 50));
            }
                    
        }
    }
}
