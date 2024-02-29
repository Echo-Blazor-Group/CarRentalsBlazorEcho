using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.Extensions.Logging;

namespace CarRentalsBlazorEcho.Data
{
    public class CookieHandler : DelegatingHandler
    {
        private readonly ILogger<CookieHandler> _logger;
        public CookieHandler(ILogger<CookieHandler> logger)
        {
            _logger = logger;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
