namespace SwgohComlink.Client.Requests;

public interface IRequest<T> where T : class
{
    static abstract string Endpoint { get; }
    static abstract HttpMethod HttpMethod { get; }

    /// <summary>
    ///     Indicates whether the response is plain text instead of JSON.
    ///     Override to return true for endpoints that return non-JSON responses (e.g., Prometheus metrics).
    /// </summary>
    static virtual bool IsPlainTextResponse => false;
}