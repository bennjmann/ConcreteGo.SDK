using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConcreteGo.Api.Client;
using ConcreteGo.Api.Client.Models.Options;

namespace ConcreteGo.Api.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds ConcreteGoApiClient using configuration section binding with automatic options injection
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConcreteGoApiOptions>(configuration.GetSection(ConcreteGoApiOptions.Section));
            services.AddSingleton<IValidateOptions<ConcreteGoApiOptions>, ConcreteGoApiOptionsValidator>();
            services.AddScoped<ConcreteGoApiClient>();

            return services;
        }

        /// <summary>
        /// Adds ConcreteGoApiClient with explicit parameters (no dependency injection)
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClient(this IServiceCollection services,
            string username, string password, string appId, string appKey, string? slug = null)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            if (string.IsNullOrWhiteSpace(appId))
                throw new ArgumentException("AppId cannot be null or empty", nameof(appId));
            if (string.IsNullOrWhiteSpace(appKey))
                throw new ArgumentException("AppKey cannot be null or empty", nameof(appKey));

            services.AddScoped(_ =>
                new ConcreteGoApiClient(username, password, appId, appKey, slug));

            return services;
        }

        /// <summary>
        /// Adds ConcreteGoApiClient with action-based configuration
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClient(this IServiceCollection services,
            Action<ConcreteGoApiOptions> configureOptions)
        {
            if (configureOptions == null)
                throw new ArgumentNullException(nameof(configureOptions));
            services.Configure(configureOptions);
            services.AddSingleton<IValidateOptions<ConcreteGoApiOptions>, ConcreteGoApiOptionsValidator>();
            services.AddScoped<ConcreteGoApiClient>();

            return services;
        }

        /// <summary>
        /// Adds ConcreteGoApiClient with both configuration binding and action-based configuration
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClient(this IServiceCollection services,
            IConfiguration configuration, Action<ConcreteGoApiOptions>? configureOptions = null)
        {
            services.Configure<ConcreteGoApiOptions>(config =>
            {
                configuration.GetSection(ConcreteGoApiOptions.Section).Bind(config);
                configureOptions?.Invoke(config);
            });
            services.AddSingleton<IValidateOptions<ConcreteGoApiOptions>, ConcreteGoApiOptionsValidator>();
            services.AddScoped<ConcreteGoApiClient>();

            return services;
        }

        /// <summary>
        /// Adds ConcreteGoApiClient as a singleton for use in background services and scheduled tasks.
        /// Note: This should only be used when the client needs to persist across the application lifetime.
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClientSingleton(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConcreteGoApiOptions>(configuration.GetSection(ConcreteGoApiOptions.Section));
            services.AddSingleton<IValidateOptions<ConcreteGoApiOptions>, ConcreteGoApiOptionsValidator>();
            services.AddSingleton<ConcreteGoApiClient>();

            return services;
        }

        /// <summary>
        /// Adds ConcreteGoApiClient as a singleton with explicit parameters
        /// </summary>
        public static IServiceCollection AddConcreteGoApiClientSingleton(this IServiceCollection services,
            string username, string password, string appId, string appKey, string? slug = null)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            if (string.IsNullOrWhiteSpace(appId))
                throw new ArgumentException("AppId cannot be null or empty", nameof(appId));
            if (string.IsNullOrWhiteSpace(appKey))
                throw new ArgumentException("AppKey cannot be null or empty", nameof(appKey));
            services.AddSingleton<ConcreteGoApiClient>(_ =>
                new ConcreteGoApiClient(username, password, appId, appKey, slug));

            return services;
        }

    }



    /// <summary>
    /// Validates ConcreteGoApiOptions configuration at startup
    /// </summary>
    internal class ConcreteGoApiOptionsValidator : IValidateOptions<ConcreteGoApiOptions>
    {
        public ValidateOptionsResult Validate(string? name, ConcreteGoApiOptions options)
        {
            var failures = new List<string>();

            if (string.IsNullOrWhiteSpace(options.Username))
                failures.Add("Username is required");

            if (string.IsNullOrWhiteSpace(options.Password))
                failures.Add("Password is required");

            if (string.IsNullOrWhiteSpace(options.AppId))
                failures.Add("AppId is required");

            if (string.IsNullOrWhiteSpace(options.AppKey))
                failures.Add("AppKey is required");

            return failures.Count > 0
                ? ValidateOptionsResult.Fail(failures)
                : ValidateOptionsResult.Success;
        }
    }
}
