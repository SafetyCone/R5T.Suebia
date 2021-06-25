using System;

using R5T.Suebia.Standard;


namespace System
{
    public static class ISecretsDirectoryFilePathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            ISecretsDirectoryFilePathAggregation01 other)
            where T : ISecretsDirectoryFilePathAggregation01
        {
            (aggregation as ISecretsDirectoryPathAggregation01).FillFrom(other);

            aggregation.SecretsDirectoryFilePathProviderAction = other.SecretsDirectoryFilePathProviderAction;

            return aggregation;
        }
    }
}
