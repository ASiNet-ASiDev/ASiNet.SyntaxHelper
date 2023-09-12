namespace ASiNet.AssemblysHelper;
public static class AssemblysHelper
{
    static AssemblysHelper()
    {
        DefaultAssemblysPath = Path.GetDirectoryName(typeof(object).Assembly.Location)!;
    }

    public static string DefaultAssemblysPath { get; }
    public static string AssemblyExe { get; set; } = ".dll";

    public static bool TryGetDefaultAssembluPath(string assembluName, out string? path)
    {
        try
        {
            path = GetDefaultAssembluPath(assembluName);
            if (File.Exists(AssemblyExe))
                return true;
            return false;
        }
        catch
        {
            path = null;
            return false;
        }
    }

    public static string GetDefaultAssembluPath(string assembluName) => Path.Combine(DefaultAssemblysPath, $"{assembluName}{AssemblyExe}");

}