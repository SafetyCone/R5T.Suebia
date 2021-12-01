using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria.Default;
using R5T.Bulgaria.UserProfileDirectory;
using R5T.Carpathia.Costobocia;
using R5T.Carpathia.Default;
using R5T.Costobocia.Bulgaria;
using R5T.Costobocia.Default;
using R5T.Dacia;
using R5T.Lombardy;
using R5T.Ostrogothia;
using R5T.Quadia.Carpathia;
using R5T.Suebia.Default;
using R5T.Suebia.Quadia;
using R5T.Visigothia.Default;


namespace R5T.Suebia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static SecretsDirectoryPathPrerequisitesAggregation01 AddSecretsDirectoryPathProviderActionPrerequisites(this IServiceCollection services,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var userProfileDirectoryPathProviderAction = services.AddUserProfileDirectoryPathProviderAction_Old();
            var dropboxDirectoryNameProviderAction = services.AddDropboxDirectoryNameProviderAction_Old();
            var organizationsDirectoryNameProviderAction = services.AddOrganizationsDirectoryNameProviderAction_Old();
            var organizationDirectoryNameProviderAction = services.AddOrganizationDirectoryNameProviderAction_Old(
                organizationProviderAction);

            var dropboxDirectoryPathProviderAction = services.AddDropboxDirectoryPathProviderAction_Old(
                dropboxDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction);

            var organizationsDirectoryPathProviderAction = services.AddOrganizationsDirectoryPathProviderAction_Old(
                dropboxDirectoryPathProviderAction,
                organizationsDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);

            // Use the shared organization directory.
            // Use organizaztional directory path provider for shared organization directory path provider.
            var organizationalDirectoryPathProviderAction = services.AddOrganizationDirectoryPathProviderAction_Old(
                organizationDirectoryNameProviderAction,
                organizationsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var sharedDirectoryNameProviderAction = services.AddSharedDirectoryNameProviderAction_Old();
            var sharedOrganizationDirectoryPathProviderAction = services.AddSharedOrganizationDirectoryPathProviderAction_Old(
                organizationalDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);
            var organizationDirectoryPathProviderAction = services.UseSharedOrganizationDirectoryPathProviderAction_Old(
                sharedOrganizationDirectoryPathProviderAction);

            var organizationDataDirectoryPathProviderAction = services.AddOrganizationDataDirectoryPathProviderAction_Old(
                organizationDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new SecretsDirectoryPathPrerequisitesAggregation01
            {
                DropboxDirectoryNameProviderAction = dropboxDirectoryNameProviderAction,
                DropboxDirectoryPathProviderAction = dropboxDirectoryPathProviderAction,
                OrganizationalDirectoryPathProviderAction = organizationalDirectoryPathProviderAction,
                OrganizationDataDirectoryPathProviderAction = organizationDataDirectoryPathProviderAction,
                OrganizationDirectoryNameProviderAction = organizationDirectoryNameProviderAction,
                OrganizationDirectoryPathProviderAction = organizationDirectoryPathProviderAction,
                OrganizationsDirectoryNameProviderAction = organizationsDirectoryNameProviderAction,
                OrganizationsDirectoryPathProviderAction = organizationsDirectoryPathProviderAction,
                SharedDirectoryNameProviderAction = sharedDirectoryNameProviderAction,
                SharedOrganizationDirectoryPathProviderAction = sharedOrganizationDirectoryPathProviderAction,
                UserProfileDirectoryPathProviderAction = userProfileDirectoryPathProviderAction,
            };
        }

        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static SecretsDirectoryPathAggregation01 AddSecretsDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var secretsDirectoryPathPrerequisiteServices = services.AddSecretsDirectoryPathProviderActionPrerequisites(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryPathProviderAction = services.AddSecretsDirectoryPathProviderAction_Old(
                secretsDirectoryPathPrerequisiteServices.OrganizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new SecretsDirectoryPathAggregation01
            {
                SecretsDirectoryPathProviderAction = secretsDirectoryPathProviderAction,
            }
            .FillFrom(secretsDirectoryPathPrerequisiteServices)
            ;
        }

        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static SecretsDirectoryFilePathAggregation01 AddSecretsDirectoryFilePathProviderServices(this IServiceCollection services,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var secretsDirectoryPathServices = services.AddSecretsDirectoryPathProviderAction(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryFilePathProviderAction = services.AddSecretsDirectoryFilePathProviderAction_Old(
                secretsDirectoryPathServices.SecretsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new SecretsDirectoryFilePathAggregation01
            {
                SecretsDirectoryFilePathProviderAction = secretsDirectoryFilePathProviderAction,
            }
            .FillFrom(secretsDirectoryPathServices);
        }

        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static OrganizationDataSecretsDirectoryPathAggregation01 AddSecretsDirectoryPathProviderActionAsOrganizationDataSecretsAction(this IServiceCollection services,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var secretsDirectoryPathPrerequisiteServices = services.AddSecretsDirectoryPathProviderActionPrerequisites(
                organizationProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryPathProviderAction = services.AddSecretsDirectoryPathProviderAsOrganizationDataSecretsAction_Old(
                secretsDirectoryPathPrerequisiteServices.OrganizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return new OrganizationDataSecretsDirectoryPathAggregation01
            {
                OrganizationDataSecretsDirectoryPathProviderAction = secretsDirectoryPathProviderAction,
            }
            .FillFrom(secretsDirectoryPathPrerequisiteServices)
            ;
        }
    }
}
