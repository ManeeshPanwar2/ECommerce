public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }
    
    // Add any additional properties or methods here
    
    // Constructor
    public Order(int orderId, DateTime orderDate, string customerName, decimal totalAmount)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }
}