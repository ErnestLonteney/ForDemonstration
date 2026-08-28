namespace FacadeExample
{
    internal class OrderMaker(Order order)
    {
        public bool IsCancelled { get; set; }
        public bool IsConfirmed { get; set; }

        public string Reason { get; private set; } = string.Empty;

        public StorageManager StorageManager { get; } = new();
        public PriceCalculator PriceCalculator { get; } = new();
        public MailSender MailSender { get; } = new();

        public void MakeOrder()
        {
            if (StorageManager.IsAvialiable(order.ProductName, order.Qty))
            {
                StorageManager.Reserve(order.ProductName, order.Qty);
                decimal price = PriceCalculator.CalculatePrice(order);
                IsConfirmed = true; 
                MailSender.SendMailRegardingOrder($"Dear {order.CustomerName},\n\nThank you for your order of {order.Qty} units of '{order.ProductName}'. The total price for your order is ${price}. We will process your order shortly and notify you once it has been shipped.\n\nBest regards,\nYour Company", order);
            }
            else
            {
                IsConfirmed = false;
                MailSender.SendMailRegardingOrder($"Dear {order.CustomerName},\n\nWe regret to inform you that the product '{order.ProductName}' is currently unavailable in the requested quantity of {order.Qty}. We apologize for any inconvenience this may cause and appreciate your understanding.\n\nBest regards,\nYour Company", order);   
            }
        }

        public void CancelOrder(string reason)
        {
            Reason = reason;    
            StorageManager.CancelReservation(order.ProductName, order.Qty);
            IsCancelled = true;
            MailSender.SendMailRegardingOrder($"Dear {order.CustomerName},\n\nWe regret to inform you that your order for '{order.ProductName}' has been cancelled.\n\nBest regards,\nYour Company", order);
        }
    }
}
