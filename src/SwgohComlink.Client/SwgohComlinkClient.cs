using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client;

public class SwgohComlinkClient(HttpClient httpClient, ILogger<SwgohComlinkClient> logger) : ISwgohComlinkClient
{
    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request,
        CancellationToken cancellationToken = default) where TRequest : IRequest<TResponse> where TResponse : class
    {
        var endpoint = TRequest.Endpoint;
        var method = TRequest.HttpMethod;

        HttpResponseMessage response;

        if (method == HttpMethod.Get)
        {
            response = await httpClient.GetAsync(endpoint, cancellationToken);
        }
        else
        {
            response = await httpClient.PostAsJsonAsync(endpoint, request, cancellationToken);
        }

        response.EnsureSuccessStatusCode();

        try
        {
            var rawContent = await response.Content.ReadAsStringAsync(cancellationToken);

            logger.LogDebug("Response status: {StatusCode}, Content length: {ContentLength} bytes", response.StatusCode,
                rawContent.Length);

            if (string.IsNullOrWhiteSpace(rawContent))
            {
                logger.LogError("Received empty response body from endpoint: {Endpoint}", endpoint);
                throw new InvalidOperationException($"Empty response received from endpoint: {endpoint}");
            }

            var result = JsonSerializer.Deserialize<TResponse>(rawContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (result == null)
            {
                logger.LogError("Deserialization returned null for endpoint: {Endpoint}. Raw content: {RawContent}",
                    endpoint, rawContent);

                throw new InvalidOperationException($"Response deserialization returned null for endpoint: {endpoint}");
            }

            return result;
        }
        catch (JsonException ex)
        {
            var rawContent = await response.Content.ReadAsStringAsync(cancellationToken);

            logger.LogError(ex,
                "Failed to deserialize response from endpoint: {Endpoint}. Response type: {ResponseType}. Raw content: {RawContent}",
                endpoint, typeof(TResponse).Name, rawContent);

            throw new InvalidOperationException(
                $"Failed to deserialize response from {endpoint} to {typeof(TResponse).Name}. See inner exception for details.",
                ex);
        }
        catch (Exception ex) when (ex is not InvalidOperationException)
        {
            logger.LogError(ex,
                "Unexpected error processing response from endpoint: {Endpoint}. Response type: {ResponseType}",
                endpoint, typeof(TResponse).Name);
            
            throw;
        }
    }
}