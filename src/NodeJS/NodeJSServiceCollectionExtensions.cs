using Jering.JavascriptUtils.Node;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up NodeServices in an <see cref="IServiceCollection" />.
    /// </summary>
    public static class NodeJSServiceCollectionExtensions
    {
        /// <summary>
        /// Adds NodeServices support to the <paramref name="services"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        public static void AddNode(this IServiceCollection services)
        {
            services.AddLogging();
            services.AddOptions();
            services.AddSingleton<IEmbeddedResourcesService, EmbeddedResourcesService>();
            services.AddSingleton<IInvocationRequestFactory, InvocationRequestFactory>();
            services.AddSingleton<IHttpClientFactory, HttpClientFactory>();
            services.AddSingleton<INodeJSProcessFactory, NodeJSProcessFactory>();
            services.AddSingleton<INodeJSService, HttpNodeJSService>();
        }
    }
}