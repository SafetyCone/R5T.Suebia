using System;

using R5T.T0063;


namespace R5T.Suebia.Standard
{
    public interface IServiceActionAggregation03 : IServiceActionAggregation02
    {
        IServiceAction<ISecretsDirectoryFilePathProvider> SecretsDirectoryFilePathProviderAction { get; set; }
    }
}
