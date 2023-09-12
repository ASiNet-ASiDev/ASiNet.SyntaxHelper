using ASiNet.AssemblysHelper.AssemblyNodes;

namespace ASiNet.AssemblysHelper;
public class AssemblyTrees
{
    private static AssemblyTrees? _shared;
    public static AssemblyTrees Shared => _shared ??= new AssemblyTrees();

    public static char SeparatorChar { get; set; } = '.';

    public static void ClearShared() => _shared = null;

    public SystemAssemblyNode System { get; } = new("System");
}