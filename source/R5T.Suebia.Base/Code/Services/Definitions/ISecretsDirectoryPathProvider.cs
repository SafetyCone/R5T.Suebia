using System;
using System.Threading.Tasks;


namespace R5T.Suebia
{
    public interface ISecretsDirectoryPathProvider
    {
        Task<string> GetSecretsDirectoryPath();
    }
}
