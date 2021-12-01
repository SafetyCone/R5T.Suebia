using System;

using R5T.Suebia.Standard;

using IOrganizationDataDirectoryPathProviderServiceActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;


namespace System
{
    public static class IServiceActionAggregation02Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation02 other)
            where T : IServiceActionAggregation02
        {
            (aggregation as IOrganizationDataDirectoryPathProviderServiceActionAggregation).FillFrom(other);

            aggregation.SecretsDirectoryPathProviderAction = other.SecretsDirectoryPathProviderAction;

            return aggregation;
        }
    }
}