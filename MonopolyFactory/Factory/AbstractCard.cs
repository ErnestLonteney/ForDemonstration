namespace MonopolyFactory.Factory
{
    abstract class AbstractCard(string instruction)
    {
        public string Instruction { get; } = instruction;
    }
}
