using ECommerce.Controllers;

public interface IOrderService
{
    Task<Order> GetOrderById(int orderId);
    Task<IEnumerable<Order>> GetAllOrders();
    Task<Order> CreateOrder(Order order);
    Task<Order> UpdateOrder(Order order);
    Task DeleteOrder(int orderId);
    Task<Order?> GetOrder(string orderId); // Add return type here

    void ProcessOrder(Task<Order?> order); // Add void return type here
    Task<int> CreateOrder(OrderDto orderDto);
    Task<OrderDto> GetOrderDetails(int orderId);
    Task UpdateOrderStatus(int orderId, OrderStatusDto orderStatusDto);
}