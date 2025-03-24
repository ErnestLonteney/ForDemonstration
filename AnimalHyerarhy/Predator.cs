namespace AnimalHyerarhy
{
    abstract class Predator : WildAnimal
    {
        public Predator(string name) 
            : base(name)
        {
        }
        public abstract void Hunt();
        public Herbivore [] Victims;
}
}