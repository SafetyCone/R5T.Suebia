using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Quadia;


namespace R5T.Suebia.Quadia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<ISecretsDirectoryPathProvider, SecretsDirectoryPathProvider>()
                .Run(organizationDataDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<ISecretsDirectoryPathProvider>(() => services.AddSecretsDirectoryPathProvider(
                organizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
