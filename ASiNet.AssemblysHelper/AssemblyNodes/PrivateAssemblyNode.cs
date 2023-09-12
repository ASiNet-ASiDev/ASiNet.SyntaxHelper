namespace ASiNet.AssemblysHelper.AssemblyNodes;
public class PrivateAssemblyNode : AssemblyNodeBase
{
    public PrivateAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        CoreLib = new("CoreLib", this);
        DataContractSerialization = new("DataContractSerialization", this);
        Uri = new("Uri", this);
        Xml = new("Xml", this);
    }

    public LastAssemblyNode CoreLib { get; init; }
    public LastAssemblyNode DataContractSerialization { get; init; }
    public LastAssemblyNode Uri { get; init; }
    public PrivateXmlAssemblyNode Xml { get; init; }
}

public class PrivateXmlAssemblyNode : AssemblyNodeBase
{
    public PrivateXmlAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Linq = new("Linq", this);
    }

    public LastAssemblyNode Linq { get; init; }
}

public class TransactionsAssemblyNode : AssemblyNodeBase
{
    public TransactionsAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Local = new("Local", this);
    }

    public LastAssemblyNode Local { get; init; }
}


public class WebAssemblyNode : AssemblyNodeBase
{
    public WebAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        HttpUtility = new("HttpUtility", this);
    }

    public LastAssemblyNode HttpUtility { get; init; }
}