namespace SwgohComlink.Client.Requests;

public interface IRequest<T> where T : class
{
    static abstract string Endpoint { get; }
    static abstract HttpMethod HttpMethod { get; }
}