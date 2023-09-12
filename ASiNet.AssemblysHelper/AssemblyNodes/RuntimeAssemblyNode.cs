namespace ASiNet.AssemblysHelper.AssemblyNodes;
public class RuntimeAssemblyNode : AssemblyNodeBase
{
    public RuntimeAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        CompilerServices = new("CompilerServices", this);
        InteropServices = new("InteropServices", this);
        Extensions = new("Extensions", this);
        Handles = new("Handles", this);
        Intrinsics = new("Intrinsics", this);
        Loader = new("Loader", this);
        Numerics = new("Numerics", this);
        Serialization = new("Serialization", this);
    }

    public CompilerServicesAssemblyNode CompilerServices { get; init; }
    public InteropServicesAssemblyNode InteropServices { get; init; }
    public SerializationAssemblyNode Serialization { get; init; }
    public LastAssemblyNode Extensions { get; init; }
    public LastAssemblyNode Handles { get; init; }
    public LastAssemblyNode Intrinsics { get; init; }
    public LastAssemblyNode Loader { get; init; }
    public LastAssemblyNode Numerics { get; init; }
}


public class CompilerServicesAssemblyNode : AssemblyNodeBase
{
    public CompilerServicesAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        VisualC = new("VisualC", this);
        Unsafe = new("Unsafe", this);
    }

    public LastAssemblyNode VisualC { get; init; }
    public LastAssemblyNode Unsafe { get; init; }
}

public class InteropServicesAssemblyNode : AssemblyNodeBase
{
    public InteropServicesAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        JavaScript = new("JavaScript", this);
        RuntimeInformation = new("RuntimeInformation", this);
    }

    public LastAssemblyNode JavaScript { get; init; }
    public LastAssemblyNode RuntimeInformation { get; init; }
}

public class SerializationAssemblyNode : AssemblyNodeBase
{
    public SerializationAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Json = new("Json", this);
        Xml = new("Xml", this);
        Primitives = new("Primitives", this);
        Formatters = new("Formatters", this);
    }

    public LastAssemblyNode Json { get; init; }
    public LastAssemblyNode Xml { get; init; }
    public LastAssemblyNode Primitives { get; init; }
    public LastAssemblyNode Formatters { get; init; }
}