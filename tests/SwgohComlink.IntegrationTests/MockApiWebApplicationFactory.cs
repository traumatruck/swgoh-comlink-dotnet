using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SwgohComlink.IntegrationTests;

/// <summary>
///     Custom WebApplicationFactory for integration testing with the Mock API.
/// </summary>
public class MockApiWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Development");
    }
}