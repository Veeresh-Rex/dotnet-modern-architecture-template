using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Api.Model;

public class OrderManagementError : ProblemDetails
{
    public IDictionary<string, string[]>? Errors { get; set; }
}
