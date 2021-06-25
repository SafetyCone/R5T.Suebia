using System;

using R5T.Dacia;


namespace R5T.Suebia.Standard
{
    public class SecretsDirectoryPathAggregation01 : SecretsDirectoryPathPrerequisitesAggregation01, ISecretsDirectoryPathAggregation01
    {
        public IServiceAction<ISecretsDirectoryPathProvider> SecretsDirectoryPathProviderAction { get; set; }
    }
}
