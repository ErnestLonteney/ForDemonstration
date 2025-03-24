namespace AnimalHyerarhy
{
    abstract class Herbivore : WildAnimal
    {
        public Herbivore(string name) 
            : base(name)
        {
        }
        public abstract void Herd();
}
}