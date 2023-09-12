namespace ASiNet.AssemblysHelper.AssemblyNodes;

public class IOAssemblyNode : AssemblyNodeBase
{
    public IOAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Compression = new("Compression", this);
        FileSystem = new("FileSystem", this);
        Pipes = new("Pipes", this);

        IsolatedStorage = new("IsolatedStorage", this);
        MemoryMappedFiles = new("MemoryMappedFiles", this);
        UnmanagedMemoryStream = new("UnmanagedMemoryStream", this);
    }

    public IOCompressionAssemblyNode Compression { get; init; }
    public IOPipesAssemblyNode Pipes { get; init; }
    public IOFileSystemAssemblyNode FileSystem { get; init; }

    public LastAssemblyNode IsolatedStorage { get; init; }
    public LastAssemblyNode MemoryMappedFiles { get; init; }
    public LastAssemblyNode UnmanagedMemoryStream { get; init; }
}

public class IOCompressionAssemblyNode : AssemblyNodeBase
{
    public IOCompressionAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        FileSystem = new("FileSystem", this);
        Native = new("Native", this);
        ZipFile = new("ZipFile", this);
        Brotli = new("Brotli", this);
    }

    public LastAssemblyNode Brotli { get; init; }
    public LastAssemblyNode FileSystem { get; init; }
    public LastAssemblyNode Native { get; init; }
    public LastAssemblyNode ZipFile { get; init; }
}

public class IOFileSystemAssemblyNode : AssemblyNodeBase
{
    public IOFileSystemAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        AccessControl = new("AccessControl", this);
        DriveInfo = new("DriveInfo", this);
        Primitives = new("Primitives", this);
        Watcher = new("Watcher", this);
    }

    public LastAssemblyNode AccessControl { get; init; }
    public LastAssemblyNode DriveInfo { get; init; }
    public LastAssemblyNode Primitives { get; init; }
    public LastAssemblyNode Watcher { get; init; }
}

public class IOPipesAssemblyNode : AssemblyNodeBase
{
    public IOPipesAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        AccessControl = new("AccessControl", this);
    }

    public LastAssemblyNode AccessControl { get; init; }
}