using FilesValidatorProblem.Models;
using System.Reflection;

namespace FilesValidatorProblem
{
    public static class DeviceFileConfigValidatorResolver
    {
        public static IFileValidator<T>? Resolve<T>() where T : BaseDeviceConfigFile
        {
            var validator = Assembly.GetAssembly(typeof(T))?.GetTypes()?
                .FirstOrDefault(x => !x.IsInterface && x.IsClass && x.IsAssignableTo(typeof(IFileValidator<T>)));

            if (validator is not null)
            {
                return Activator.CreateInstance(validator) as IFileValidator<T>;
            }

            return default;
        }
    }
}
