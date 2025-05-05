﻿namespace OrderManagement.Api.ExceptionHandlers;

public class GlobalExecptionHandler : BaseExecptionHandler<Exception>
{
    public override string ExceptionType => "General exception";
    public override IDictionary<string, string[]> GetErrorMessage(Exception exception)
    {
        return new Dictionary<string, string[]>
        {
            { "SystemError", new[] { "Some issues occurred while processing your request." } },
        };
    }
}
