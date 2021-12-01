using System;

using R5T.Suebia.Quadia;

using R5T.T0063;

using IOrganizationDataDirectoryPathProviderServiceActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;


namespace R5T.Suebia.Standard
{
    public interface IServiceActionAggregation04 : IOrganizationDataDirectoryPathProviderServiceActionAggregation
    {
        IServiceAction<IOrganizationDataSecretsDirectoryPathProvider> OrganizationDataSecretsDirectoryPathProviderAction { get; set; }
    }
}
