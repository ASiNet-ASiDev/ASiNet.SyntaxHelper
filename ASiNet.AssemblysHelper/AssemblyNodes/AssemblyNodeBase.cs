namespace ASiNet.AssemblysHelper.AssemblyNodes;
public abstract class AssemblyNodeBase : IAssemblyNode
{
    public AssemblyNodeBase(string assemblyName, IAssemblyNode? parent)
    {
        _parent = parent;
        AssemblyName = assemblyName;
        FullAssemblyName = GetFullAssemblyName(AssemblyName, _parent);
        AssemblyPath = AssemblysHelper.GetDefaultAssembluPath(FullAssemblyName);
    }

    public string AssemblyName { get; }
    public string FullAssemblyName { get; }
    public string AssemblyPath { get; }

    protected IAssemblyNode? _parent;

    protected static string GetFullAssemblyName(string assemblyName, IAssemblyNode? parent = null) => 
        parent is null ? assemblyName : $"{parent.FullAssemblyName}{AssemblyTrees.SeparatorChar}{assemblyName}";

    public static implicit operator string(AssemblyNodeBase node) => node.AssemblyPath;
}