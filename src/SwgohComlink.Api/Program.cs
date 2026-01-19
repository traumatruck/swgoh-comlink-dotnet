using Scalar.AspNetCore;
using SwgohComlink.Api.Endpoints;
using SwgohComlink.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

// Configure the Swgoh Comlink client
var comlinkBaseUrl = builder.Configuration["SwgohComlink:BaseUrl"] 
    ?? throw new InvalidOperationException("SwgohComlink:BaseUrl configuration is required");

builder.Services.AddSwgohComlink(comlinkBaseUrl);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

// Map all endpoints
app.MapHealthEndpoints();
app.MapGameDataEndpoints();
app.MapPlayerEndpoints();
app.MapGuildEndpoints();
app.MapLeaderboardEndpoints();
app.MapEventEndpoints();

app.Run();