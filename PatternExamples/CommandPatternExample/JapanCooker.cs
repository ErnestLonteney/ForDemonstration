namespace CommandPatternExample
{
    internal class JapanCooker : Executer
    {
        public override void MakeFish(byte countPorcions)
        {
            for (int i = 0; i < countPorcions; i++)
                Console.WriteLine("Japanise cook cooks fish");
        }

        public override void MakeRice(byte countPorcions)
        {
            for (int i = 0; i < countPorcions; i++)
                MakeChickenWithRice();
        }

        public override void MakeChicken(byte countPorcions)
        {
            for (int i = 0; i < countPorcions; i++)
                MakeChickenWithRice();
        }


        private void MakeChickenWithRice()
        {
            Console.WriteLine("Japanise cook cooks rice with chicken");
        }
    }
}
