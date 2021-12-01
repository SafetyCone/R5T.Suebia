using System;

using R5T.Suebia.Standard;

using IOrganizationDataDirectoryPathProviderServiceActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;


namespace System
{
    public static class IServiceActionAggregation04Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation04 other)
            where T : IServiceActionAggregation04
        {
            (aggregation as IOrganizationDataDirectoryPathProviderServiceActionAggregation).FillFrom(other);

            aggregation.OrganizationDataSecretsDirectoryPathProviderAction = other.OrganizationDataSecretsDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
