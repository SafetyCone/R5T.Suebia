using System;

using R5T.Dacia;


namespace R5T.Suebia.Standard
{
    public interface ISecretsDirectoryFilePathAggregation01 : ISecretsDirectoryPathAggregation01
    {
        IServiceAction<ISecretsDirectoryFilePathProvider> SecretsDirectoryFilePathProviderAction { get; set; }
    }
}
