using System;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Quadia;

using R5T.T0064;


namespace R5T.Suebia.Quadia
{
    [ServiceImplementationMarker]
    public class SecretsDirectoryPathProvider : IOrganizationDataSecretsDirectoryPathProvider, IServiceImplementation
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
