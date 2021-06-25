using System;

using R5T.Dacia;


namespace R5T.Suebia.Standard
{
    public interface ISecretsDirectoryPathAggregation01 : ISecretsDirectoryPathPrerequisitesAggregation01
    {
        IServiceAction<ISecretsDirectoryPathProvider> SecretsDirectoryPathProviderAction { get; set; }
    }
}
