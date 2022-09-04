namespace FilesValidatorProblem.Models
{
    public class UsbDeviceConfigFile : BaseDeviceConfigFile
    {
        public UsbDeviceConfigFile(string name, string version, string extension) : base(name, version, extension)
        {
        }

        public override string GetConfiguration()
        {
            return @"{
                'diagnosticsMode' : 'Info',
                'showErrors': False,
            }";
        }
    }
}
