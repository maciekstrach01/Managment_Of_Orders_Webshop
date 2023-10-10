public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }

    public Order(int orderId, string customerName)
    {
        OrderId = orderId;
        CustomerName = customerName;
    }

    public override string ToString()
    {
        return $"Order ID: {OrderId}, Client name: {CustomerName}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Order otherOrder = (Order)obj;
        return OrderId == otherOrder.OrderId;
    }

    public override int GetHashCode()
    {
        return OrderId;
    }
}