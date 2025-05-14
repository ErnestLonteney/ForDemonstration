namespace AnimalHyerarhy
{
    abstract class DomesticAnimal : Animal
    {
        protected DomesticAnimal(string name) 
            : base(name)
        {
        }

        public abstract void Depasture();
    }
}