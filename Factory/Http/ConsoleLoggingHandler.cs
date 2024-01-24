public class ConsoleLoggingHandler : DelegatingHandler
{
    public ConsoleLoggingHandler(HttpMessageHandler innerHandler) : base(innerHandler)
    {
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        string requestHeader = request.ToString();
        string requestContent = string.Empty;
        string responseHeader = string.Empty;
        string responseContent = string.Empty;

        //custom headers
        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36");

        if (request.Content != null)
        {
            requestContent = await request.Content.ReadAsStringAsync();
        }
        //Console.WriteLine($"-> {requestContent}");

        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

        responseHeader = response.ToString();
        if (response.Content != null)
        {
            responseContent = await response.Content.ReadAsStringAsync();
            responseContent = responseContent.Replace("\n", "");
        }
        //Console.WriteLine($"<- {responseContent}");

        return response;
    }


}
