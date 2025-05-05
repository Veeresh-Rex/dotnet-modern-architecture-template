using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.DTOs;
using OrderManagement.Application.Interfaces;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<ActionResult> GetOrders()
    {
        List<OrderDto> orderDtos = await _orderService.GetAllOrdersAsync();
        if (orderDtos == null || orderDtos.Count == 0)
        {
            return NotFound();
        }

        return Ok(orderDtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetOrder(string id)
    {
        OrderDto? orderDto = await _orderService.GetOrderByIdAsync(id);

        if (orderDto is null)
        {
            return NotFound();
        }
        return Ok(orderDto);
    }

    [HttpPost]
    public async Task<ActionResult> CreateOrder(OrderDto dto)
    {
        if (dto == null)
        {
            return BadRequest();
        }
        OrderDto createdOrder = await _orderService.CreateOrderAsync(dto);
        return CreatedAtAction(nameof(GetOrder), new { id = createdOrder.Id }, createdOrder);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrder(int id, OrderDto dto)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrder(int id)
    {
        return NoContent();
    }

}
