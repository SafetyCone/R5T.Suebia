using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Suebia.Default
{
    [ServiceImplementationMarker]
    public class SecretsDirectoryFilePathProvider : ISecretsDirectoryFilePathProvider, IServiceImplementation
    {
        private ISecretsDirectoryPathProvider SecretsDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsDirectoryFilePathProvider(
            ISecretsDirectoryPathProvider secretsDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.SecretsDirectoryPathProvider = secretsDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetSecretsFilePath(string fileName)
        {
            var secretsDirectoryPath = await this.SecretsDirectoryPathProvider.GetSecretsDirectoryPath();

            var filePath = this.StringlyTypedPathOperator.GetFilePath(secretsDirectoryPath, fileName);
            return filePath;
        }
    }
}
