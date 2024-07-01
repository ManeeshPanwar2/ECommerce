using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ECommerceController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public ECommerceController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
        {
            try
            {
                // Validate orderDto and handle potential user errors gracefully

                int orderId = await _orderService.CreateOrder(orderDto);

                return Ok(orderId);
            }
            catch (Exception ex)
            {
                // Implement a robust error handling strategy to capture and log exceptions for troubleshooting
                // Provide informative error messages to the client for debugging purposes

                return StatusCode(500, "An error occurred while creating the order.");
            }
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderDetails(int orderId)
        {
            try
            {
                OrderDto order = (OrderDto) await _orderService.GetOrderDetails(orderId);

                if (order == null)
                {
                    return NotFound();
                }

                return Ok(order);
            }
            catch (Exception ex)
            {
                // Implement a robust error handling strategy to capture and log exceptions for troubleshooting
                // Provide informative error messages to the client for debugging purposes

                return StatusCode(500, "An error occurred while retrieving the order details.");
            }
        }

        [HttpPut("{orderId}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, [FromBody] OrderStatusDto orderStatusDto)
        {
            try
            {
                // Validate orderStatusDto and handle potential user errors gracefully

                await _orderService.UpdateOrderStatus(orderId, orderStatusDto);

                return NoContent();
            }
            catch (Exception ex)
            {
                // Implement a robust error handling strategy to capture and log exceptions for troubleshooting
                // Provide informative error messages to the client for debugging purposes

                return StatusCode(500, "An error occurred while updating the order status.");
            }
        }
    }


    
}