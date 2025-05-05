using System;

namespace OrderManagement.Application.DTOs;

public class OrderDto
{
    public string? Id { get; set; }
    public string CustomerName { get; set; } = "";
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}
