using System;

namespace OrderManagement.Domain.Entities;

public class Order
{
    public string Id { get; set; }
    public string CustomerName { get; set; } = "";
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }
}
