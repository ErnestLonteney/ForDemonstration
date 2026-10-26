namespace CommandPatternExample
{
    internal class Waiter
    {
        private Queue<Command> commands = [];

        public void AddCommand(Command command)
        {
            commands.Enqueue(command);
            Report.Orders.Add($"Added command");   
        }

        public void ExecuteCommands()
        {
            while (commands.Count > 0)
            {
                var command = commands.Dequeue();
                command.Execute();
                Report.Orders.Add($"Executed command");
            }
        }

        public void CancelCommand(Command command)
        {
            var orders = commands.ToList();

            orders.Remove(command);

            commands = new Queue<Command>(orders);
        }
    }
}
