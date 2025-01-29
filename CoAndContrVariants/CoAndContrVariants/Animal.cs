namespace CoAndContrVariants
{
    abstract class Animal : IVoice
    {
        public string Name { get; protected set; } 
        public string Kind { get; protected set; }
        public abstract void MakeVoice();    
    }
}
