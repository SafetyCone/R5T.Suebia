using System;

using R5T.Lombardy;
using R5T.Quadia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Suebia.Quadia
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="IOrganizationDataSecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderActionAsOrganizationDataSecretsDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOrganizationDataSecretsDirectoryPathProvider>(services => services.AddSecretsDirectoryPathProviderAsOrganizationDataSecretsDirectoryPathProvider(
                organizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsDirectoryPathProvider"/> implementation of <see cref="ISecretsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ISecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationDataDirectoryPathProvider> organizationDataDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<ISecretsDirectoryPathProvider>(services => services.AddSecretsDirectoryPathProvider(
                organizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
