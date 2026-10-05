using DeliverGo.Api.Client.Authentication;
using DeliverGo.Api.Client.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DeliverGo.Api.Client.Extensions
{
    /// <summary>
    /// Registration helpers for the DeliverGo API client.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers <see cref="IDeliverGoApiClient"/> and its authentication pipeline,
        /// binding <see cref="DeliverGoOptions"/> from the supplied configuration section.
        /// </summary>
        public static IHttpClientBuilder AddDeliverGoApiClient(this IServiceCollection services, IConfiguration configurationSection)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configurationSection);

            services.AddOptions<DeliverGoOptions>()
                .Bind(configurationSection)
                .Validate(Validate, "DeliverGo client options are invalid.")
                .ValidateOnStart();

            return AddCore(services);
        }

        /// <summary>
        /// Registers <see cref="IDeliverGoApiClient"/> and its authentication pipeline
        /// using the supplied configuration delegate.
        /// </summary>
        public static IHttpClientBuilder AddDeliverGoApiClient(this IServiceCollection services, Action<DeliverGoOptions> configure)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configure);

            services.AddOptions<DeliverGoOptions>()
                .Configure(configure)
                .Validate(Validate, "DeliverGo client options are invalid.")
                .ValidateOnStart();

            return AddCore(services);
        }

        private static bool Validate(DeliverGoOptions options)
        {
            options.Validate();
            return true;
        }

        private static IHttpClientBuilder AddCore(IServiceCollection services)
        {
            services.AddSingleton<IDeliverGoTokenProvider, DeliverGoTokenProvider>();
            services.AddTransient<DeliverGoAuthenticationHandler>();

            services.AddHttpClient(DeliverGoTokenProvider.HttpClientName, static (provider, client) =>
            {
                DeliverGoOptions options = provider.GetRequiredService<IOptions<DeliverGoOptions>>().Value;
                client.Timeout = options.Timeout;
            });

            return services.AddHttpClient<IDeliverGoApiClient, DeliverGoApiClient>(static (provider, client) =>
            {
                DeliverGoOptions options = provider.GetRequiredService<IOptions<DeliverGoOptions>>().Value;
                client.BaseAddress = options.BaseAddress;
                client.Timeout = options.Timeout;
            })
            .AddHttpMessageHandler<DeliverGoAuthenticationHandler>();
        }
    }
}
