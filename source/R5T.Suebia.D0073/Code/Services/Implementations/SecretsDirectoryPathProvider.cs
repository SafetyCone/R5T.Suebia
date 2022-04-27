using System;
using System.Threading.Tasks;

using R5T.Suebia.Quadia;

using R5T.D0065;
using R5T.D0073;
using R5T.D0073.T002;using R5T.T0064;


namespace R5T.Suebia.D0073
{[ServiceImplementationMarker]
    public class SecretsDirectoryPathProvider : IMachineLocationAwareSecretsDirectoryPathProvider,IServiceImplementation
    {
        private IExecutableDirectoryPathProvider ExecutableDirectoryPathProvider { get; }
        private IMachineLocationProvider MachineLocationProvider { get; }
        private IOrganizationDataSecretsDirectoryPathProvider OrganizationDataSecretsDirectoryPathProvider { get; }


        public SecretsDirectoryPathProvider(
            IExecutableDirectoryPathProvider executableDirectoryPathProvider,
            IMachineLocationProvider machineLocationProvider,
            IOrganizationDataSecretsDirectoryPathProvider organizationDataSecretsDirectoryPathProvider)
        {
            this.ExecutableDirectoryPathProvider = executableDirectoryPathProvider;
            this.MachineLocationProvider = machineLocationProvider;
            this.OrganizationDataSecretsDirectoryPathProvider = organizationDataSecretsDirectoryPathProvider;
        }

        public async Task<string> GetSecretsDirectoryPath()
        {
            var machineLocation = await this.MachineLocationProvider.GetMachineLocation();

            var output = await MachineLocations.Switch(machineLocation,
                () => this.OrganizationDataSecretsDirectoryPathProvider.GetSecretsDirectoryPath(),
                () => this.ExecutableDirectoryPathProvider.GetExecutableDirectoryPath());

            return output;
        }
    }
}
