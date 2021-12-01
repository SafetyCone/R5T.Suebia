using System;

using R5T.Lombardy;
using R5T.Ostrogothia;
using R5T.Quadia.A001;
using R5T.Suebia.Default;
using R5T.Suebia.Quadia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Suebia.Standard
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static IServiceActionAggregation02 AddSecretsDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var organizationDataDirectoryPathProviderActions = _.AddOrganizationDataDirectoryPathProviderActions(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryPathProviderAction = _.AddSecretsDirectoryPathProviderAction(
                organizationDataDirectoryPathProviderActions.OrganizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new ServiceActionAggregation02
            {
                SecretsDirectoryPathProviderAction = secretsDirectoryPathProviderAction,
            }
            .FillFrom(organizationDataDirectoryPathProviderActions)
            ;
        }

        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static IServiceActionAggregation03 AddSecretsDirectoryFilePathProviderServices(this IServiceAction _,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var secretsDirectoryPathServices = _.AddSecretsDirectoryPathProviderAction(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryFilePathProviderAction = _.AddSecretsDirectoryFilePathProviderAction(
                secretsDirectoryPathServices.SecretsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new ServiceActionAggregation03
            {
                SecretsDirectoryFilePathProviderAction = secretsDirectoryFilePathProviderAction,
            }
            .FillFrom(secretsDirectoryPathServices);
        }

        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static IServiceActionAggregation04 AddSecretsDirectoryPathProviderActionAsOrganizationDataSecretsAction(this IServiceAction _,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var organizationDataDirectoryPathProviderActions = _.AddOrganizationDataDirectoryPathProviderActions(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryPathProviderAction = _.AddSecretsDirectoryPathProviderActionAsOrganizationDataSecretsDirectoryPathProviderAction(
                organizationDataDirectoryPathProviderActions.OrganizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new ServiceActionAggregation04
            {
                OrganizationDataSecretsDirectoryPathProviderAction = secretsDirectoryPathProviderAction,
            }
            .FillFrom(organizationDataDirectoryPathProviderActions)
            ;
        }
    }
}
