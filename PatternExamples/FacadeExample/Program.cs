namespace FacadeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                CustomerName = "John Doe",
                CustomerAddress = "123 Main St, Anytown, USA",
                Phone = "555-1234",
                Email = "john@mail.com",
                ProductName = "product1",
                Qty = 5
            };

            var orderMaker = new OrderMaker(order);
            orderMaker.MakeOrder();
            orderMaker.CancelOrder("Customer requested cancellation");

            orderMaker.PriceCalculator.CalculatePrice(order);
            orderMaker.MailSender.SendMailRegardingOrder("Your order has been processed.", order);

        }
    }
}
