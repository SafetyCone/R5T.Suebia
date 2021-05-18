using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Bulgaria.Default;
using R5T.Bulgaria.UserProfileDirectory;
using R5T.Carpathia;
using R5T.Carpathia.Costobocia;
using R5T.Carpathia.Default;
using R5T.Costobocia;
using R5T.Costobocia.Bulgaria;
using R5T.Costobocia.Default;
using R5T.Dacia;
using R5T.Lombardy;
using R5T.Ostrogothia;
using R5T.Quadia;
using R5T.Quadia.Carpathia;
using R5T.Suebia.Default;
using R5T.Suebia.Quadia;
using R5T.Visigothia;
using R5T.Visigothia.Default;

using IOrganizationDirectoryPathProvider = R5T.Carpathia.IOrganizationDirectoryPathProvider;
using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Suebia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Uses the Dropbox/Rivet/Shared/Secrets directory.
        /// </summary>
        public static
            (
            IServiceAction<ISecretsDirectoryFilePathProvider> _,
            IServiceAction<ISecretsDirectoryPathProvider> SecretsDirectoryPathProviderAction,
            IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction,
            IServiceAction<IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction,
            IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction,
            IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction,
            IServiceAction<IOrganizationalDirectoryPathProvider> OrganizationalDirectoryPathProviderAction,
            IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction,
            IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction, 
            IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction,
            IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction,
            IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction,
            IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction
            )
        AddSecretsDirectoryFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IOrganizationProvider> organizationProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction
            )
        {
            var userProfileDirectoryPathProviderAction = services.AddUserProfileDirectoryPathProviderAction();
            var dropboxDirectoryNameProviderAction = services.AddDropboxDirectoryNameProviderAction();
            var organizationsDirectoryNameProviderAction = services.AddOrganizationsDirectoryNameProviderAction();
            var organizationDirectoryNameProviderAction = services.AddOrganizationDirectoryNameProviderAction(
                organizationProviderAction);

            var dropboxDirectoryPathProviderAction = services.AddDropboxDirectoryPathProviderAction(
                dropboxDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction);

            var organizationsDirectoryPathProviderAction = services.AddOrganizationsDirectoryPathProviderAction(
                dropboxDirectoryPathProviderAction,
                organizationsDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);

            // Use the shared organization directory.
            // Use organizaztional directory path provider for shared organization directory path provider.
            var organizationalDirectoryPathProviderAction = services.AddOrganizationDirectoryPathProviderAction(
                organizationDirectoryNameProviderAction,
                organizationsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var sharedDirectoryNameProviderAction = services.AddSharedDirectoryNameProviderAction();
            var sharedOrganizationDirectoryPathProviderAction = services.AddSharedOrganizationDirectoryPathProviderAction(
                organizationalDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);
            var organizationDirectoryPathProviderAction = services.UseSharedOrganizationDirectoryPathProviderAction(
                sharedOrganizationDirectoryPathProviderAction);

            var organizationDataDirectoryPathProviderAction = services.AddOrganizationDataDirectoryPathProviderAction(
                organizationDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryPathProviderAction = services.AddSecretsDirectoryPathProviderAction(
                organizationDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var secretsDirectoryFilePathProviderAction = services.AddSecretsDirectoryFilePathProviderAction(
                secretsDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            return
                (
                secretsDirectoryFilePathProviderAction,
                secretsDirectoryPathProviderAction,
                organizationDataDirectoryPathProviderAction,
                organizationDirectoryPathProviderAction,
                sharedOrganizationDirectoryPathProviderAction,
                sharedDirectoryNameProviderAction,
                organizationalDirectoryPathProviderAction,
                organizationDirectoryNameProviderAction,
                organizationsDirectoryPathProviderAction,
                organizationsDirectoryNameProviderAction,
                dropboxDirectoryPathProviderAction,
                dropboxDirectoryNameProviderAction,
                userProfileDirectoryPathProviderAction
                );
        }
    }
}
