using System;


namespace R5T.Suebia.Standard
{
    public static class SecretsDirectoryPathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            SecretsDirectoryPathAggregation01 other)
            where T : SecretsDirectoryPathAggregation01
        {
            (aggregation as SecretsDirectoryPathPrerequisitesAggregation01).FillFrom(other);

            aggregation.SecretsDirectoryPathProviderAction = other.SecretsDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
