using System.Collections.Generic;
using System.Threading.Tasks;
using OrderManagement.Application.DTOs;

namespace OrderManagement.Application.Interfaces;

public interface IOrderService
{
    Task<List<OrderDto>> GetAllOrdersAsync();
    Task<OrderDto?> GetOrderByIdAsync(string id);
    Task<OrderDto> CreateOrderAsync(OrderDto orderDto);
    Task UpdateOrderAsync(string id, OrderDto orderDto);
    Task DeleteOrderAsync(string id);
}
