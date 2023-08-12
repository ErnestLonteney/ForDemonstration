namespace PhoneExample
{
    public class Contact
    {
        private string[] numbers;

        public Guid Id { get; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string[] Numbers { get => numbers; }
      
        public Contact(string fname, string number)
        {
            Id = Guid.NewGuid();    
            FirsName = fname;  
            numbers = new string[2];
            numbers[0] = number;
        }       
       
        public Contact(
            string fname, 
            string number1, 
            string lastname = null, 
            string number2 = null)
        {
            numbers[1] = number2;     
        }

    }
}
