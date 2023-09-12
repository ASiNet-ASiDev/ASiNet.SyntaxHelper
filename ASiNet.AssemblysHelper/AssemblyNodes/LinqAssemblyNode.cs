namespace ASiNet.AssemblysHelper.AssemblyNodes;
public class LinqAssemblyNode : AssemblyNodeBase
{
    public LinqAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Expressions = new("Expressions", this);
        Parallel = new("Parallel", this);
        Queryable = new("Queryable", this);
    }

    public LastAssemblyNode Expressions { get; init; }
    public LastAssemblyNode Parallel { get; init; }
    public LastAssemblyNode Queryable { get; init; }
}
