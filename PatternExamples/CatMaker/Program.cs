namespace CatMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prototypeCat = new Cat("Proto")
            {
                Color1 = "Tabby",
                Color2 = "Black",
                Color3 = "White"
            };

            var ogiginal = (Cat)prototypeCat.Clone();
            ogiginal.Color1 = "Calico";

            var clone1 = (Cat)ogiginal;
            clone1.Color2 = "Ginger";
            clone1.Color3 = "Grey";

            var clone2 = (Cat)ogiginal.Clone();
            clone2.Color3 = "Blue";

            var clone3 = (Cat)clone1.Clone();
            clone3.Color3 = "Orange";  
        }
    }
}