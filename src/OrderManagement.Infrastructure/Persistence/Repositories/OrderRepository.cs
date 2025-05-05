using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;

namespace OrderManagement.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    public OrderRepository()
    {

    }

    public async Task<List<Order>> GetAllAsync()
    {
        await Task.Delay(500);
        return new List<Order>()
        {
            new Order
            {
                Id = Guid.NewGuid().ToString(),
                CustomerName = "Veeresh Maurya",
                OrderDate = DateTime.UtcNow.AddDays(-2),
                TotalAmount = 1500.00m,
            }
        };
    }

    public async Task<Order?> GetByIdAsync(string id)
    {
        await Task.Delay(500);
        return new()
        {
            Id = id,
            CustomerName = "Veeresh Maurya",
            OrderDate = DateTime.UtcNow.AddDays(-2),
            TotalAmount = 1500.00m,
        };
    }

    public async Task<Order> AddAsync(Order order)
    {
        await Task.Delay(500);
        Order newOrder = new Order
        {
            Id = Guid.NewGuid().ToString(),
            CustomerName = order.CustomerName,
            OrderDate = order.OrderDate,
            TotalAmount = order.TotalAmount
        };

        return newOrder;
    }

    public async Task UpdateAsync(Order order)
    {
        await Task.Delay(500);
    }

    public async Task DeleteAsync(string id)
    {
        await Task.Delay(500);
    }
}
