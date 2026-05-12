using MonopolyFactory.Factory;

namespace MonopolyFactory
{
    internal class ClassicCard(string instruction, byte[] image = null) : AbstractCard(instruction)
    {
        public byte[] Image { get; set; } = image;
    }
}
