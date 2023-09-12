namespace ASiNet.AssemblysHelper.AssemblyNodes;

public class CollectionsAssemblyNode : AssemblyNodeBase
{
    public CollectionsAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Concurrent = new("Concurrent", this);
        Immutable = new("Immutable", this);
        NonGeneric = new("NonGeneric", this);
        Specialized = new("Specialized", this);
    }

    public LastAssemblyNode Concurrent { get; init; }
    public LastAssemblyNode Immutable { get; init; }
    public LastAssemblyNode NonGeneric { get; init; }
    public LastAssemblyNode Specialized { get; init; }
}
