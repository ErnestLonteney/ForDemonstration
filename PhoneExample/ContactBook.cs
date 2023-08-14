namespace PhoneExample
{
    public class ContactBook
    {

        private const string ContactsDoesNotExists = "Contact does not exist in the book";
        private readonly Contact[] contacts;

        public ContactBook(int size)
        {
            contacts = new Contact[size];
        }

        public int Count { get; private set; }

        public Contact this[Guid index]
        {
            get 
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] != null && contacts[i].Id == index)
                    {
                        return contacts[i]; 
                    }
                }

                return null;
            }         
        }       

        public Guid AddContact(Contact contact)
        {
            int index = FindFreePlace();
            if (index == -1)
            {
                IncreeseArray();
                index = FindFreePlace();
            }
            contacts[index] = contact;  

            Count++;

            return contact.Id;
        }

        private void IncreeseArray()
        {
            Contact[] newArray = new Contact[contacts.Length * 2];
            Array.Copy(contacts, newArray, contacts.Length);
        }

        public void RemoveContact(Guid id, out string errorMessage)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null && contacts[i].Id == id)
                {
                    contacts[i] = null;
                    Count--;
                    errorMessage = String.Empty;

                    return;
                }
            }

            errorMessage = ContactsDoesNotExists;
        }

        private int FindFreePlace()
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] == null)
                    return i;
            }

            return -1;
        }

        public Contact[] GetAllContacts()
        {
            int count = 0;
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] == null)
                {
                    count = i - 1;
                    break;
                }
            }

            return contacts[0..count];
        }      
    }
}
