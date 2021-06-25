using System;

using R5T.Bulgaria;
using R5T.Carpathia;
using R5T.Costobocia;
using R5T.Dacia;
using R5T.Quadia;
using R5T.Visigothia;

using IOrganizationDirectoryPathProvider = R5T.Carpathia.IOrganizationDirectoryPathProvider;
using IOrganizationalDirectoryPathProvider = R5T.Costobocia.IOrganizationDirectoryPathProvider;


namespace R5T.Suebia.Standard
{
    public class SecretsDirectoryPathPrerequisitesAggregation01 : ISecretsDirectoryPathPrerequisitesAggregation01
    {
        public IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction { get; set; }
        public IServiceAction<IOrganizationalDirectoryPathProvider> OrganizationalDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction { get; set; }
        public IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction { get; set; }
    }
}
