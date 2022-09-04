namespace FilesValidatorProblem.Models
{
    public class ObdDeviceConfigFile : BaseDeviceConfigFile
    {
        public ObdDeviceConfigFile(string name, string version, string extension) : base(name, version, extension)
        {
        }

        public override string GetConfiguration()
        {
            return @"{
                'diagnosticsMode' : 'Trace',
                'showErrors': True,
            }";
        }
    }
}
