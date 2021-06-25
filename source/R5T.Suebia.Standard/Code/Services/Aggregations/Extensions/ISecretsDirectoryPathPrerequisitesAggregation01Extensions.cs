using System;


namespace R5T.Suebia.Standard
{
    public static class ISecretsDirectoryPathPrerequisitesAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            ISecretsDirectoryPathPrerequisitesAggregation01 other)
            where T : ISecretsDirectoryPathPrerequisitesAggregation01
        {
            aggregation.DropboxDirectoryNameProviderAction = other.DropboxDirectoryNameProviderAction;
            aggregation.DropboxDirectoryPathProviderAction = other.DropboxDirectoryPathProviderAction;
            aggregation.OrganizationalDirectoryPathProviderAction = other.OrganizationalDirectoryPathProviderAction;
            aggregation.OrganizationDataDirectoryPathProviderAction = other.OrganizationDataDirectoryPathProviderAction;
            aggregation.OrganizationDirectoryNameProviderAction = other.OrganizationDirectoryNameProviderAction;
            aggregation.OrganizationDirectoryPathProviderAction = other.OrganizationDirectoryPathProviderAction;
            aggregation.OrganizationsDirectoryNameProviderAction = other.OrganizationsDirectoryNameProviderAction;
            aggregation.OrganizationsDirectoryPathProviderAction = other.OrganizationsDirectoryPathProviderAction;
            aggregation.SharedDirectoryNameProviderAction = other.SharedDirectoryNameProviderAction;
            aggregation.SharedOrganizationDirectoryPathProviderAction = other.SharedOrganizationDirectoryPathProviderAction;
            aggregation.UserProfileDirectoryPathProviderAction = other.UserProfileDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
