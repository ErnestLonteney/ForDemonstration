namespace CommandPatternExample
{
    internal class OrderFish(Executer executer,  byte countPorsions) : Command(executer)
    {
        public override void Execute()
        {
            executer.MakeFish(countPorsions);
        }

        
    }
}
