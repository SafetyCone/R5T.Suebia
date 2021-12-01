using System;

using R5T.Suebia.Standard;


namespace System
{
    public static class IServiceActionAggregation03Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation03 other)
            where T : IServiceActionAggregation03
        {
            (aggregation as IServiceActionAggregation02).FillFrom(other);

            aggregation.SecretsDirectoryFilePathProviderAction = other.SecretsDirectoryFilePathProviderAction;

            return aggregation;
        }
    }
}
