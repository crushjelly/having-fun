using FilesValidatorProblem.Models;

namespace FilesValidatorProblem
{
    public class DeviceConfigFileHandler
    {
        /// <summary>
        /// Handles BaseDeviceConfigFiles, performs certain operations and returns concrete file result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseDeviceConfigFiles"></param>
        /// <returns></returns>
        public static T? Handle<T>(IEnumerable<BaseDeviceConfigFile> baseDeviceConfigFiles) where T : BaseDeviceConfigFile
        {
            var file = baseDeviceConfigFiles.FirstOrDefault(x => x.GetType() == typeof(T)) as T;
            if (file == null)
            {
                return default;
            }

            var validator = DeviceFileConfigValidatorResolver.Resolve<T>();
            validator?.Validate(file);
            return file;
        }
    }
}
