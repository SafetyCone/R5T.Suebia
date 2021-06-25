using System;


namespace R5T.Suebia.Standard
{
    public static class IOrganizationDataSecretsDirectoryPathAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IOrganizationDataSecretsDirectoryPathAggregation01 other)
            where T : IOrganizationDataSecretsDirectoryPathAggregation01
        {
            (aggregation as ISecretsDirectoryPathPrerequisitesAggregation01).FillFrom(other);

            aggregation.OrganizationDataSecretsDirectoryPathProviderAction = other.OrganizationDataSecretsDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
