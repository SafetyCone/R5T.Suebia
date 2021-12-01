using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Quadia;

using R5T.T0063;


namespace R5T.Suebia.Quadia
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationDataDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<ISecretsDirectoryPathProvider, SecretsDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataSecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProviderAsOrganizationDataSecretsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationDataDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IOrganizationDataSecretsDirectoryPathProvider, SecretsDirectoryPathProvider>();

            return services;
        }
    }
}
