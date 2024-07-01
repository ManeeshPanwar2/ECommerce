using System;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace E_Commerce.Services
{
    public class OrderService : IOrderService
    {
        private readonly ILogger _logger;

        public OrderService(ILogger logger)
        {
            _logger = logger;
        }

        public Task<Order> CreateOrder(Order order)
        {
            _logger.LogInformation("CreateOrder method called");
            throw new NotImplementedException();
        }

        public Task<int> CreateOrder(OrderDto orderDto)
        {
            _logger.LogInformation("CreateOrder method called");
            throw new NotImplementedException();
        }

        public Task DeleteOrder(int orderId)
        {
            _logger.LogInformation("DeleteOrder method called");
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            _logger.LogInformation("GetAllOrders method called");
            throw new NotImplementedException();
        }

        public Task<Order?> GetOrder(string orderId)
        {
            _logger.LogInformation("GetOrder method called");
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int orderId)
        {
            _logger.LogInformation("GetOrderById method called");
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetOrderDetails(int orderId)
        {
            _logger.LogInformation("GetOrderDetails method called");
            throw new NotImplementedException();
        }

        public void ProcessOrder(Task<Order?> order)
        {
            _logger.LogInformation("ProcessOrder method called");
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrder(Order order)
        {
            _logger.LogInformation("UpdateOrder method called");
            throw new NotImplementedException();
        }

        public Task UpdateOrderStatus(int orderId, OrderStatusDto orderStatusDto)
        {
            _logger.LogInformation("UpdateOrderStatus method called");
            throw new NotImplementedException();
        }
    }
}