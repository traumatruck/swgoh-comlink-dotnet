using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client;

public interface ISwgohComlinkClient
{
    TResponse SendRequest<TRequest, TResponse>(TRequest request)
        where TRequest : IRequest<TResponse> where TResponse : class;
}