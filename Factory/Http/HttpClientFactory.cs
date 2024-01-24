using System.Net;

public class HttpClientFactory
{
    private static string? _baseUrl;

    private static readonly Lazy<HttpClient> _instance = new Lazy<HttpClient>(
            () =>
            {
                var httpClientHandler = new HttpClientHandler() { UseDefaultCredentials = true, DefaultProxyCredentials = CredentialCache.DefaultCredentials };
                var loggingHandler = new ConsoleLoggingHandler(httpClientHandler);
                return new HttpClient(loggingHandler, true) { BaseAddress = new Uri(_baseUrl ?? ""), Timeout = TimeSpan.FromMinutes(50) };

            }, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication
        );


    public static HttpClient GetHttpClientInstance(string baseUrl)
    {
        _baseUrl = baseUrl;

        return _instance.Value;
    }

    public static void Destroy()
    {
        _instance.Value.Dispose();
    }
}
