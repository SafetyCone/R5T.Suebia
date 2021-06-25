using System;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Quadia;


namespace R5T.Suebia.Quadia
{
    public class SecretsDirectoryPathProvider : IOrganizationDataSecretsDirectoryPathProvider
    {
        private IOrganizationDataDirectoryPathProvider OrganizationDataDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsDirectoryPathProvider(
            IOrganizationDataDirectoryPathProvider organizationDataDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.OrganizationDataDirectoryPathProvider = organizationDataDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetSecretsDirectoryPath()
        {
            var organizationDataDirectoryPath = await this.OrganizationDataDirectoryPathProvider.GetOrganizationDataDirectoryPath();

            var secretsDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(organizationDataDirectoryPath, SecretsDirectory.Name);
            return secretsDirectoryPath;
        }
    }
}
