using AutoMapper;
using OrderManagement.Application.DTOs;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Mappings;

public class OrderMapper : Profile
{
    public OrderMapper()
    {
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}
