using FilesValidatorProblem.Models;

namespace FilesValidatorProblem
{
    public interface IFileValidator
    {
    }

    public interface IFileValidator<T> : IFileValidator where T : BaseDeviceConfigFile
    {
        void Validate(T file);
    }
}