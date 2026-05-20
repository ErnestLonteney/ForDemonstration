namespace CatMaker
{
    internal class Cat : ICloneable
    {
        public string Number { get; set; }
        
        public string Color1 { get; set; }  

        public string Color2 { get; set; }

        public string Color3 { get; set; } = string.Empty;


        public Cat(string number)
        {
            Number = number;
        }

        public object Clone()
        {
            return MemberwiseClone();   
        }
    }
}
