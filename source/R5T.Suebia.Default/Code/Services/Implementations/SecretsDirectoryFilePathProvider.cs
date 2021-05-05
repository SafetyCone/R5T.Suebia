using System;
using System.Threading.Tasks;

using R5T.Lombardy;


namespace R5T.Suebia.Default
{
    public class SecretsDirectoryFilePathProvider : ISecretsDirectoryFilePathProvider
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
