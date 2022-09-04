using FilesValidatorProblem.Models;

namespace FilesValidatorProblem
{
    public class ObdDeviceConfigFileValidator : IFileValidator<ObdDeviceConfigFile>
    {
        public void Validate(ObdDeviceConfigFile file)
        {
            var configuration = file.GetConfiguration();
            if (configuration is null)
            {
                throw new Exception("OBD device configuration is missing.");
            }

            if (file.Version != "0.0.0.1")
            {
                throw new Exception("OBD device configuration file version is incompatible.");
            }

            // Some other configuration
        }
    }
}
