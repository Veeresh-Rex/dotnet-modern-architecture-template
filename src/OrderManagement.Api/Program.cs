using OrderManagement.Api.Extensions;
using OrderManagement.Api.Middleware;
using OrderManagement.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationServices();
builder.Services.AddAppHealthChecks();
builder.Services.AddSwagger();
builder.Services.AddApiCors(builder.Configuration["AllowedHosts"] ?? string.Empty);
builder.Services.AddPersistance();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapHeartbeat();

app.UseAuthorization();

app.MapControllers();
app.UseMiddleware<CorrelationIdMiddleware>();

await app.RunAsync();

public partial class Program
{
    protected Program()
    {
    }
}