using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Suebia.Quadia;

using R5T.D0065;
using R5T.D0073;


namespace R5T.Suebia.D0073
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IMachineLocationProvider> machineLocationProviderAction,
            IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> organizationDataSecretsDirectoryPathProviderAction)
        {
            services.AddSingleton<ISecretsDirectoryPathProvider, SecretsDirectoryPathProvider>()
                .Run(executableDirectoryPathProviderAction)
                .Run(machineLocationProviderAction)
                .Run(organizationDataSecretsDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IMachineLocationProvider> machineLocationProviderAction,
            IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> organizationDataSecretsDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<ISecretsDirectoryPathProvider>(() => services.AddSecretsDirectoryPathProvider(
                executableDirectoryPathProviderAction,
                machineLocationProviderAction,
                organizationDataSecretsDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISecretsDirectoryPathProvider> AddMachineLocationAwareSecretsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IMachineLocationProvider> machineLocationProviderAction,
            IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> organizationDataSecretsDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<ISecretsDirectoryPathProvider>(() => services.AddSecretsDirectoryPathProvider(
                executableDirectoryPathProviderAction,
                machineLocationProviderAction,
                organizationDataSecretsDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="IMachineLocationAwareSecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProviderAsMachineLocationAwareSecretsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IMachineLocationProvider> machineLocationProviderAction,
            IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> organizationDataSecretsDirectoryPathProviderAction)
        {
            services.AddSingleton<IMachineLocationAwareSecretsDirectoryPathProvider, SecretsDirectoryPathProvider>()
                .Run(executableDirectoryPathProviderAction)
                .Run(machineLocationProviderAction)
                .Run(organizationDataSecretsDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="IMachineLocationAwareSecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMachineLocationAwareSecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderAsMachineLocationAwareSecretsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IMachineLocationProvider> machineLocationProviderAction,
            IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> organizationDataSecretsDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IMachineLocationAwareSecretsDirectoryPathProvider>(() => services.AddSecretsDirectoryPathProviderAsMachineLocationAwareSecretsDirectoryPathProvider(
                executableDirectoryPathProviderAction,
                machineLocationProviderAction,
                organizationDataSecretsDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
