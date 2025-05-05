using System.Collections.Generic;
using System.Threading.Tasks;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Domain.Repositories;

public interface IOrderRepository
{
    Task<List<Order>> GetAllAsync();
    Task<Order?> GetByIdAsync(string id);
    Task<Order> AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(string id);
}
