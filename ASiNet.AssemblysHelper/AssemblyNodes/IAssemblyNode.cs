namespace ASiNet.AssemblysHelper.AssemblyNodes;
public interface IAssemblyNode
{
    public string AssemblyName { get; }
    public string FullAssemblyName { get; }
    public string AssemblyPath { get; }
}
