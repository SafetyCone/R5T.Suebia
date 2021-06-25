using System;

using R5T.Dacia;

using R5T.Suebia.Quadia;


namespace R5T.Suebia.Standard
{
    public interface IOrganizationDataSecretsDirectoryPathAggregation01 : ISecretsDirectoryPathPrerequisitesAggregation01
    {
        IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> OrganizationDataSecretsDirectoryPathProviderAction { get; set; }
    }
}
