using System;
using System.Threading.Tasks;


namespace R5T.Suebia
{
    public interface ISecretsDirectoryFilePathProvider
    {
        /// <summary>
        /// Get the full path of a file in the secrets directory given its file name.
        /// I.e., prefix the input file name with the secrets directory path obtained from some dependency service.
        Task<string> GetSecretsFilePath(string fileName);
    }
}
