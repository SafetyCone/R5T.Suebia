using System;

using R5T.Dacia;

using R5T.Suebia.Quadia;


namespace R5T.Suebia.Standard
{
    public class OrganizationDataSecretsDirectoryPathAggregation01 : SecretsDirectoryPathPrerequisitesAggregation01, IOrganizationDataSecretsDirectoryPathAggregation01
    {
        public IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> OrganizationDataSecretsDirectoryPathProviderAction { get; set; }
    }
}
