using SwgohComlink.Client.Requests;

namespace SwgohComlink.Client;

public class SwgohComlinkClient : ISwgohComlinkClient
{
    public TResponse SendRequest<TRequest, TResponse>(TRequest request)
        where TRequest : IRequest<TResponse> where TResponse : class
    {
        throw new NotImplementedException();
    }
}