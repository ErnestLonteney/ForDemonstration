namespace CommandPatternExample
{
    internal class Program
    {
        static void Main()
        {
            var cooker1 = new JapanCooker();
            var cooker2 = new FrenchCooker();
            var waiter = new Waiter();


            var order1 = new OrderFish(cooker1, 2);
            waiter.AddCommand(order1);

            var order2 = new OrderChicken(cooker2, 1);
            waiter.AddCommand(order2);

            waiter.CancelCommand(order2);

            var order3 = new OrderChicken(cooker1, 2);
            waiter.AddCommand(order3);

            waiter.ExecuteCommands();
        }
    }
}
