namespace ASiNet.AssemblysHelper.AssemblyNodes;
public class ThreadingAssemblyNode : AssemblyNodeBase
{
    public ThreadingAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Tasks = new("Tasks", this);

        Channels = new("Channels", this);
        Overlapped = new("Overlapped", this);
        Thread = new("Thread", this);
        ThreadPool = new("ThreadPool", this);
        Timer = new("Timer", this);
    }

    public TasksAssemblyNode Tasks { get; init; }

    public LastAssemblyNode Channels { get; init; }
    public LastAssemblyNode Overlapped { get; init; }
    public LastAssemblyNode Thread { get; init; }
    public LastAssemblyNode ThreadPool { get; init; }
    public LastAssemblyNode Timer { get; init; }
}



public class TasksAssemblyNode : AssemblyNodeBase
{
    public TasksAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Dataflow = new("Dataflow", this);
        Extensions = new("Extensions", this);
        Parallel = new("Parallel", this);
    }

    public LastAssemblyNode Dataflow { get; init; }
    public LastAssemblyNode Extensions { get; init; }
    public LastAssemblyNode Parallel { get; init; }
}
