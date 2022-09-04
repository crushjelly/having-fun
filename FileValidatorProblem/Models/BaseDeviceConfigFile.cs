namespace FilesValidatorProblem.Models
{
    public abstract class BaseDeviceConfigFile
    {
        protected BaseDeviceConfigFile(string name, string version, string extension)
        {
            Name = name;
            Version = version;
            Extension = extension;
        }

        public string Name { get; init; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;

        public abstract string GetConfiguration();
    }
}
