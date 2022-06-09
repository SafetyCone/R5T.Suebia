using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Suebia
{
    [ServiceDefinitionMarker]
    public interface ISecretsDirectoryFilePathProvider : IServiceDefinition
    {
        /// <summary>
        /// Get the full path of a file in the secrets directory given its file name.
        /// I.e., prefix the input file name with the secrets directory path obtained from some dependency service.
        /// </summary>
        Task<string> GetSecretsFilePath(string fileName);
    }
}
