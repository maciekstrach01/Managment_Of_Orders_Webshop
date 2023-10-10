public class OrderManagementSystem
{
    private HashSet<Order> _orders = new HashSet<Order>();

    public bool PlaceOrder(int orderId, string customerName)
    {
        return _orders.Add(new Order(orderId, customerName));
    }

    public void CancelOrder(int orderId)
    {
        _orders.RemoveWhere(order => order.OrderId == orderId);
    }

    public void DisplayOrders()
    {
        foreach (Order order in _orders)
        {
            Console.WriteLine(order);
        }
    }

    public int TotalOrders()
    {
        return _orders.Count;
    }
}