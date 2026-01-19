using System.Net.Http.Json;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client;

public class SwgohComlinkClient(HttpClient httpClient) : ISwgohComlinkClient
{
    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request,
        CancellationToken cancellationToken = default) where TRequest : IRequest<TResponse> where TResponse : class
    {
        var endpoint = TRequest.Endpoint;
        var method = TRequest.HttpMethod;

        HttpResponseMessage response;

        if (method == HttpMethod.Get)
            response = await httpClient.GetAsync(endpoint, cancellationToken);
        else
            response = await httpClient.PostAsJsonAsync(endpoint, request, cancellationToken);

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<TResponse>(cancellationToken);
        return result ?? throw new InvalidOperationException("Response deserialization returned null.");
    }
}