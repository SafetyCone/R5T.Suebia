using System;


namespace R5T.Suebia.Standard
{
    public static class ISecretsDirectoryPathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            ISecretsDirectoryPathAggregation01 other)
            where T : ISecretsDirectoryPathAggregation01
        {
            (aggregation as ISecretsDirectoryPathPrerequisitesAggregation01).FillFrom(other);

            aggregation.SecretsDirectoryPathProviderAction = other.SecretsDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
