using FilesValidatorProblem;
using FilesValidatorProblem.Models;

var files = GetFakeConfigFiles();

try
{
    var usbFile = DeviceConfigFileHandler.Handle<UsbDeviceConfigFile>(files);
    Console.WriteLine(usbFile?.Name);
}
catch (Exception e) { Console.WriteLine(e.Message); }

try
{
    var obdDeviceConfigFile = DeviceConfigFileHandler.Handle<ObdDeviceConfigFile>(files);
    Console.WriteLine($"{obdDeviceConfigFile?.Name} Version: {obdDeviceConfigFile?.Version}");
}
catch (Exception e) { Console.WriteLine(e.Message); }

static List<BaseDeviceConfigFile> GetFakeConfigFiles()
{
    return new List<BaseDeviceConfigFile>()
    {
        new UsbDeviceConfigFile("UsbSettings", "1.0.0.0", ".json"),
        new ObdDeviceConfigFile("ObdSettings", "0.0.0.1", ".config")
    };
}