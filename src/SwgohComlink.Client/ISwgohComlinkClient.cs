using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client;

public interface ISwgohComlinkClient
{
    Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest request,
        CancellationToken cancellationToken = default) where TRequest : IRequest<TResponse> where TResponse : class;
}