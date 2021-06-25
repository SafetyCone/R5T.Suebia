using System;


namespace R5T.Suebia.Standard
{
    public static class SecretsDirectoryPathPrerequisitesAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation01,
            SecretsDirectoryPathPrerequisitesAggregation01 other)
            where T : SecretsDirectoryPathPrerequisitesAggregation01
        {
            aggregation01.DropboxDirectoryNameProviderAction = other.DropboxDirectoryNameProviderAction;
            aggregation01.DropboxDirectoryPathProviderAction = other.DropboxDirectoryPathProviderAction;
            aggregation01.OrganizationalDirectoryPathProviderAction = other.OrganizationalDirectoryPathProviderAction;
            aggregation01.OrganizationDataDirectoryPathProviderAction = other.OrganizationDataDirectoryPathProviderAction;
            aggregation01.OrganizationDirectoryNameProviderAction = other.OrganizationDirectoryNameProviderAction;
            aggregation01.OrganizationDirectoryPathProviderAction = other.OrganizationDirectoryPathProviderAction;
            aggregation01.OrganizationsDirectoryNameProviderAction = other.OrganizationsDirectoryNameProviderAction;
            aggregation01.OrganizationsDirectoryPathProviderAction = other.OrganizationsDirectoryPathProviderAction;
            aggregation01.SharedDirectoryNameProviderAction = other.SharedDirectoryNameProviderAction;
            aggregation01.SharedOrganizationDirectoryPathProviderAction = other.SharedOrganizationDirectoryPathProviderAction;
            aggregation01.UserProfileDirectoryPathProviderAction = other.UserProfileDirectoryPathProviderAction;

            return aggregation01;
        }
    }
}
