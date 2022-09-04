using FilesValidatorProblem.Models;

namespace FilesValidatorProblem
{
    public class UsbDeviceConfigFileValidator : IFileValidator<UsbDeviceConfigFile>
    {
        public void Validate(UsbDeviceConfigFile file)
        {
            var configuration = file.GetConfiguration();
            if (configuration is null)
            {
                throw new Exception("Usb device configuration is missing.");
            }

            if (file.Version == "1.0.0.0")
            {
                throw new Exception("Usb device configuration file version is incompatible.");
            }

            // Some other configuration
        }
    }
}
