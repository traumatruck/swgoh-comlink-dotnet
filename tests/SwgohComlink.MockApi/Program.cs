using SwgohComlink.MockApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Map all mock endpoints
app.MapHealthEndpoints();
app.MapGameDataEndpoints();
app.MapPlayerEndpoints();
app.MapGuildEndpoints();
app.MapLeaderboardEndpoints();
app.MapEventEndpoints();

app.Run();

// Make the implicit Program class public so test projects can reference it
#pragma warning disable ASP0027
// ReSharper disable once ClassNeverInstantiated.Global
public partial class Program;
#pragma warning restore ASP0027