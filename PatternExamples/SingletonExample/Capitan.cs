namespace SingletonExample
{
    class Capitan
    {
        private static Lock _lock = new Lock();

        //  private static Capitan[] instances;

        //static Capitan()
        //{
        //    instances = new Capitan[3];
        //}

        private static Capitan? instance;

        protected Capitan(string number, string firstName, string lastName)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }

        public static Capitan GetCapitan(string number, string firstName, string lastName)
        {
            //int index = 0;

            //if (instances.Any(i => i is null))
            //{
            //    for (int i = 0; i < instances.Length; i++)
            //    {
            //        index = i;
            //        if (instances[i] is null)
            //        {
            //            instances[i] = new Capitan(number, firstName, lastName);
            //            break;
            //        }
            //    }
            //}

            //return instances[index];

            _lock.EnterScope();  
            if (instance is null)
            {
                instance = new Capitan(number, firstName, lastName);
            }
            _lock.Exit();

            return instance;
        }

        public string Number { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public byte Stage { get; set; } 

        public void ManageShip()
        {
            Console.WriteLine("Managing ship...");
        }
    }
}
