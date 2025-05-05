using System;
using FluentValidation;
using OrderManagement.Application.DTOs;

namespace OrderManagement.Application.Validators;

public class OrderDtoValidator : AbstractValidator<OrderDto>
{
    public OrderDtoValidator()
    {
        RuleFor(x => x.CustomerName)
            .NotEmpty().WithMessage("Customer name is required.")
            .Length(2, 100).WithMessage("Customer name must be between 2 and 100 characters.");
        RuleFor(x => x.OrderDate)
            .NotEmpty().WithMessage("Order date is required.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Order date cannot be in the future.");
        RuleFor(x => x.TotalAmount)
            .GreaterThan(0).WithMessage("Total amount must be greater than zero.");
    }
}
