using System;

using R5T.Bulgaria;
using R5T.Carpathia;
using R5T.Costobocia;
using R5T.Quadia;
using R5T.Visigothia;

using R5T.T0063;


namespace R5T.Suebia.Standard
{
    public class ServiceActionAggregation02 : IServiceActionAggregation02
    {
        public IServiceAction<ISecretsDirectoryPathProvider> SecretsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction { get; set; }
        public IServiceAction<Carpathia.IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction { get; set; }
        public IServiceAction<Costobocia.IOrganizationDirectoryPathProvider> OrganizationalDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction { get; set; }
        public IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction { get; set; }
    }
}
