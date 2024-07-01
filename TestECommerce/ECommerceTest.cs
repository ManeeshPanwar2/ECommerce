using Microsoft.AspNetCore.Mvc;
using ECommerce.Controllers;
using NUnit.Framework;
using Moq;


namespace ECommerce.Tests
{
    [TestFixture]
    public class ECommerceControllerTests
    {
        private ECommerceController _controller;
        private  Mock<IOrderService> _orderServiceMock;

        [SetUp]
        public void Setup()
        {
            _orderServiceMock = new Mock<IOrderService>();
            _controller = new ECommerceController(_orderServiceMock.Object);
        }

        [Test]
        public async Task CreateOrder_ValidOrderDto_ReturnsOkResult()
        {
            // Arrange
            var orderDto = new OrderDto { /* Initialize orderDto with valid data */ };

            // Act
            var result = await _controller.CreateOrder(orderDto);

            // Assert
            NUnit.Framework.Assert.That(result,Is.InstanceOf<OkResult>());

        [Test]
         async Task CreateOrder_InvalidOrderDto_ReturnsBadRequestResult()
        {
            // Arrange
            var orderDto = new OrderDto { /* Initialize orderDto with invalid data */ };

            // Act
            var result = await _controller.CreateOrder(orderDto);

            // Assert
             NUnit.Framework.Assert.That(result,Is.InstanceOf<BadRequestObjectResult>());
        }

        [Test]
         async Task GetOrderDetails_ExistingOrderId_ReturnsOkResultWithOrderDetails()
        {
            // Arrange
            var orderId = 123; // Replace with an existing order ID

            // Act
            var result = await _controller.GetOrderDetails(orderId);

            // Assert
            var okResult = (OkObjectResult)result;
            NUnit.Framework.Assert.That(okResult.Value,Is.InstanceOf<OrderDto>());
        }

        [Test]
         async Task GetOrderDetails_NonExistingOrderId_ReturnsNotFoundResult()
        {
            // Arrange
            var orderId = 999; // Replace with a non-existing order ID
        
            // Act
            var result = await _controller.GetOrderDetails(orderId);
        
            // Assert
            NUnit.Framework.Assert.That(result,Is.InstanceOf<NotFoundResult>());
        }

        [Test]
         async Task UpdateOrderStatus_ExistingOrderIdAndValidOrderStatusDto_ReturnsOkResult()
        {
            // Arrange
            var orderId = 123; // Replace with an existing order ID
            var orderStatusDto = new OrderStatusDto { /* Initialize orderStatusDto with valid data */ };

            // Act
            var result = await _controller.UpdateOrderStatus(orderId, orderStatusDto);

            // Assert
            NUnit.Framework.Assert.That(result,Is.InstanceOf<OkResult>());
        }

        [Test]
         async Task UpdateOrderStatus_NonExistingOrderId_ReturnsNotFoundResult()
        {
            // Arrange
            var orderId = 999; // Replace with a non-existing order ID
            var orderStatusDto = new OrderStatusDto { /* Initialize orderStatusDto with valid data */ };

            // Act
            var result = await _controller.UpdateOrderStatus(orderId, orderStatusDto);

            // Assert
            NUnit.Framework.Assert.That(result,Is.InstanceOf<NotFoundResult>());
        }
    }
}
}