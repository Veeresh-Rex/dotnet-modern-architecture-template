using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OrderManagement.Application.DTOs;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;

namespace OrderManagement.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<List<OrderDto>> GetAllOrdersAsync()
    {
        var orders = await _orderRepository.GetAllAsync();
        return _mapper.Map<List<OrderDto>>(orders);
    }

    public async Task<OrderDto?> GetOrderByIdAsync(string id)
    {
        var order = await _orderRepository.GetByIdAsync(id);
        return _mapper.Map<OrderDto>(order);
    }

    public async Task<OrderDto> CreateOrderAsync(OrderDto orderDto)
    {
        var order = _mapper.Map<Order>(orderDto);
        var createdOrder = await _orderRepository.AddAsync(order);
        return _mapper.Map<OrderDto>(createdOrder);
    }

    public async Task UpdateOrderAsync(string id, OrderDto orderDto)
    {
        var order = _mapper.Map<Order>(orderDto);
        order.Id = id;
        await _orderRepository.UpdateAsync(order);
    }

    public async Task DeleteOrderAsync(string id)
    {
        await _orderRepository.DeleteAsync(id);
    }
}
