﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Suebia.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SecretsDirectoryFilePathProvider"/> implementation of <see cref="ISecretsDirectoryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryFilePathProvider(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryPathProvider> secretsDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<ISecretsDirectoryFilePathProvider, SecretsDirectoryFilePathProvider>()
                .Run(secretsDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryFilePathProvider"/> implementation of <see cref="ISecretsDirectoryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISecretsDirectoryFilePathProvider> AddSecretsDirectoryFilePathProviderAction(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryPathProvider> secretsDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction.New<ISecretsDirectoryFilePathProvider>(() => services.AddSecretsDirectoryFilePathProvider(
                secretsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
