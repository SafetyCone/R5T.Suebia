using System;

using R5T.Dacia;


namespace R5T.Suebia.Standard
{
    public class SecretsDirectoryFilePathAggregation01 : SecretsDirectoryPathAggregation01, ISecretsDirectoryFilePathAggregation01
    {
        public IServiceAction<ISecretsDirectoryFilePathProvider> SecretsDirectoryFilePathProviderAction { get; set; }
    }
}
