namespace ASiNet.AssemblysHelper.AssemblyNodes;
public class SystemAssemblyNode : AssemblyNodeBase
{
    public SystemAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Runtime = new("Runtime", this);
        Threading = new("Threading", this);
        Private = new("Private", this);

        Core = new("Core", this);
        Console = new("Console", this);
        AppContex = new("AppContex", this);
        Buffers = new("Buffers", this);
        Memory = new("Memory", this);
        Linq = new("Linq", this);

        Collections = new("Collections", this);
        IO = new("IO", this);

        ValueTuple = new("ValueTuple", this);
        Transactions = new("Transactions", this);
        Windows = new("Windows", this);
        Web = new("Web", this);
        ServiceProcess = new("ServiceProcess", this);
        ObjectModel = new("ObjectModel", this);
        Net = new("Net", this);
        Numerics = new("Numerics", this);
        Resources = new("Resources", this);
        Text = new("Text", this);
        Reflection = new("Reflection", this);
        Globalization = new("Globalization", this);
        Security = new("Security", this);

        ServiceModel = new("ServiceModel", this);
        Data = new("Data", this);
        Diagnostics = new("Diagnostics", this);

        ComponentModel = new("ComponentModel", this);

        Xml = new("Xml", this);
    }

    public GlobalizationAssemblyNode Globalization { get; init; }
    public ReflectionAssemblyNode Reflection { get; init; }

    public RuntimeAssemblyNode Runtime { get; init; }

    public PrivateAssemblyNode Private { get; init; }

    public ThreadingAssemblyNode Threading { get; init; }

    public TransactionsAssemblyNode Transactions { get; init; }

    public CollectionsAssemblyNode Collections { get; init; }
    public LinqAssemblyNode Linq { get; init; }
    public ResourcesAssemblyNode Resources { get; init; }

    public NumericsAssemblyNode Numerics { get; init; }

    public IOAssemblyNode IO { get; init; }

    public WebAssemblyNode Web { get; init; }
    public NetAssemblyNode Net { get; init; }

    public SecurityAssemblyNode Security { get; init; }

    public ServiceModelAssemblyNode ServiceModel { get; init; }

    public DataAssemblyNode Data { get; init; }
    public DiagnosticsAssemblyNode Diagnostics { get; init; }

    public ComponentModelAssemblyNode ComponentModel { get; init; }

    public TextAssemblyNode Text { get; init; }

    public LastAssemblyNode Core { get; init; }

    public LastAssemblyNode Console { get; init; }

    public LastAssemblyNode AppContex { get; init; }

    public LastAssemblyNode Buffers { get; init; }
    public LastAssemblyNode Windows { get; init; }
    public LastAssemblyNode Memory { get; init; }
    public LastAssemblyNode ValueTuple { get; init; }
    public LastAssemblyNode ServiceProcess { get; init; }
    public LastAssemblyNode ObjectModel { get; init; }

    public LastAssemblyNode Configuration { get; init; }

    public SystemXmlAssemblyNode Xml { get; init; }
}


public class ResourcesAssemblyNode : AssemblyNodeBase
{
    public ResourcesAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Reader = new("Reader", this);
        ResourceManager = new("ResourceManager", this);
        Writer = new("Writer", this);
    }

    public LastAssemblyNode Reader { get; init; }
    public LastAssemblyNode ResourceManager { get; init; }
    public LastAssemblyNode Writer { get; init; }

}

public class NumericsAssemblyNode : AssemblyNodeBase
{
    public NumericsAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Vectors = new("Vectors", this);
    }

    public LastAssemblyNode Vectors { get; init; }
}

public class NetAssemblyNode : AssemblyNodeBase
{
    public NetAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        WebSockets = new("WebSockets", this);
        Http = new("Http", this);

        HttpListener = new("HttpListener", this);
        Mail = new("Mail", this);
        NameResolution = new("NameResolution", this);
        NetworkInformation = new("NetworkInformation", this);
        Ping = new("Ping", this);
        Primitives = new("Primitives", this);
        Quic = new("Quic", this);
        Requests = new("Requests", this);
        Security = new("Security", this);
        ServicePoint = new("ServicePoint", this);
        Sockets = new("Sockets", this);
        WebClient = new("WebClient", this);
        WebHeaderCollection = new("WebHeaderCollection", this);
        WebProxy = new("WebProxy", this);
    }

    public NetHttpAssemblyNode Http { get; init; }
    public WebSocketsAssemblyNode WebSockets { get; init; }

    public LastAssemblyNode HttpListener { get; init; }
    public LastAssemblyNode Mail { get; init; }
    public LastAssemblyNode NameResolution { get; init; }
    public LastAssemblyNode NetworkInformation { get; init; }
    public LastAssemblyNode Ping { get; init; }
    public LastAssemblyNode Primitives { get; init; }
    public LastAssemblyNode Quic { get; init; }
    public LastAssemblyNode Requests { get; init; }
    public LastAssemblyNode Security { get; init; }
    public LastAssemblyNode ServicePoint { get; init; }
    public LastAssemblyNode Sockets { get; init; }
    public LastAssemblyNode WebClient { get; init; }
    public LastAssemblyNode WebHeaderCollection { get; init; }
    public LastAssemblyNode WebProxy { get; init; }
}

public class NetHttpAssemblyNode : AssemblyNodeBase
{
    public NetHttpAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Json = new("Json", this);
    }

    public LastAssemblyNode Json { get; init; }
}

public class WebSocketsAssemblyNode : AssemblyNodeBase
{
    public WebSocketsAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Client = new("Client", this);
    }

    public LastAssemblyNode Client { get; init; }
}


public class TextAssemblyNode : AssemblyNodeBase
{
    public TextAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Encoding = new("Encoding", this);
        Json = new("Json", this);
        RegularExpressions = new("RegularExpressions", this);
    }

    public TextEncodingAssemblyNode Encoding { get; init; }
    public LastAssemblyNode Json { get; init; }
    public LastAssemblyNode RegularExpressions { get; init; }
}

public class TextEncodingAssemblyNode : AssemblyNodeBase
{
    public TextEncodingAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        CodePages = new("CodePages", this);
        Extensions = new("Extensions", this);
        Web = new("Web", this);
    }

    public LastAssemblyNode CodePages { get; init; }
    public LastAssemblyNode Extensions { get; init; }
    public LastAssemblyNode Web { get; init; }
}

public class ReflectionAssemblyNode : AssemblyNodeBase
{
    public ReflectionAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Emit = new("Emit", this);

        TypeExtensions = new("TypeExtensions", this);
        DispatchProxy = new("DispatchProxy", this);
        Extensions = new("Extensions", this);
        Metadata = new("Metadata", this);
        Primitives = new("Primitives", this);
    }

    public ReflectionEmitAssemblyNode Emit { get; init; }

    public LastAssemblyNode TypeExtensions { get; init; }
    public LastAssemblyNode DispatchProxy { get; init; }
    public LastAssemblyNode Extensions { get; init; }
    public LastAssemblyNode Metadata { get; init; }
    public LastAssemblyNode Primitives { get; init; }
}

public class ReflectionEmitAssemblyNode : AssemblyNodeBase
{
    public ReflectionEmitAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        ILGeneration = new("ILGeneration", this);
        Lightweight = new("Lightweight", this);
    }

    public LastAssemblyNode ILGeneration { get; init; }
    public LastAssemblyNode Lightweight { get; init; }
}

public class GlobalizationAssemblyNode : AssemblyNodeBase
{
    public GlobalizationAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Calendars = new("Calendars", this);
        Extensions = new("Extensions", this);
    }

    public LastAssemblyNode Calendars { get; init; }
    public LastAssemblyNode Extensions { get; init; }
}

public class SecurityAssemblyNode : AssemblyNodeBase
{
    public SecurityAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Cryptography = new("Cryptography", this);
        Principal = new("Principal", this);

        SecureString = new("SecureString", this);
        Claims = new("Claims", this);
        AccessControl = new("AccessControl", this);
    }

    public CryptographyAssemblyNode Cryptography { get; init; }
    public PrincipalAssemblyNode Principal { get; init; }

    public LastAssemblyNode SecureString { get; init; }
    public LastAssemblyNode Claims { get; init; }
    public LastAssemblyNode AccessControl { get; init; }
}

public class CryptographyAssemblyNode : AssemblyNodeBase
{
    public CryptographyAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Algorithms = new("Algorithms", this);
        Cng = new("Cng", this);
        Csp = new("Csp", this);
        Encoding = new("Encoding", this);
        OpenSsl = new("OpenSsl", this);
        Primitives = new("Primitives", this);
        X509Certificates = new("X509Certificates", this);
    }

    public LastAssemblyNode Algorithms { get; init; }
    public LastAssemblyNode Cng { get; init; }
    public LastAssemblyNode Csp { get; init; }
    public LastAssemblyNode Encoding { get; init; }
    public LastAssemblyNode OpenSsl { get; init; }
    public LastAssemblyNode Primitives { get; init; }
    public LastAssemblyNode X509Certificates { get; init; }
}

public class PrincipalAssemblyNode : AssemblyNodeBase
{
    public PrincipalAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Windows = new("Windows", this);
    }

    public LastAssemblyNode Windows { get; init; }
}

public class ServiceModelAssemblyNode : AssemblyNodeBase
{
    public ServiceModelAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Web = new("Web", this);
    }

    public LastAssemblyNode Web { get; init; }
}

public class DataAssemblyNode : AssemblyNodeBase
{
    public DataAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Common = new("Common", this);
        DataSetExtensions = new("DataSetExtensions", this);
    }

    public LastAssemblyNode Common { get; init; }
    public LastAssemblyNode DataSetExtensions { get; init; }
}

public class DiagnosticsAssemblyNode : AssemblyNodeBase
{
    public DiagnosticsAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Contracts = new("Contracts", this);
        Debug = new("Debug", this);
        DiagnosticSource = new("DiagnosticSource", this);
        FileVersionInfo = new("FileVersionInfo", this);
        Process = new("Process", this);
        StackTrace = new("StackTrace", this);
        TextWriterTraceListener = new("TextWriterTraceListener", this);
        Tools = new("Tools", this);
        TraceSource = new("TraceSource", this);
        Tracing = new("Tracing", this);
    }

    public LastAssemblyNode Contracts { get; init; }
    public LastAssemblyNode Debug { get; init; }
    public LastAssemblyNode DiagnosticSource { get; init; }
    public LastAssemblyNode FileVersionInfo { get; init; }
    public LastAssemblyNode Process { get; init; }
    public LastAssemblyNode StackTrace { get; init; }
    public LastAssemblyNode TextWriterTraceListener { get; init; }
    public LastAssemblyNode Tools { get; init; }
    public LastAssemblyNode TraceSource { get; init; }
    public LastAssemblyNode Tracing { get; init; }
}

public class ComponentModelAssemblyNode : AssemblyNodeBase
{
    public ComponentModelAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        Annotations = new("Annotations", this);
        DataAnnotations = new("DataAnnotations", this);
        EventBasedAsync = new("EventBasedAsync", this);
        Primitives = new("Primitives", this);
        TypeConverter = new("TypeConverter", this);
    }

    public LastAssemblyNode Annotations { get; init; }
    public LastAssemblyNode DataAnnotations { get; init; }
    public LastAssemblyNode EventBasedAsync { get; init; }
    public LastAssemblyNode Primitives { get; init; }
    public LastAssemblyNode TypeConverter { get; init; }
}

public class SystemXmlAssemblyNode : AssemblyNodeBase
{
    public SystemXmlAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        XPath = new("XPath", this);
        XmlSerializer = new("XmlSerializer", this);
        XmlDocument = new("XmlDocument", this);
        Serialization = new("Serialization", this);
        ReaderWriter = new("ReaderWriter", this);
        Linq = new("Linq", this);
        XDocument = new("XDocument", this);
    }

    public XmlXPathAssemblyNode XPath { get; init; }

    public LastAssemblyNode XmlSerializer { get; init; }
    public LastAssemblyNode XmlDocument { get; init; }
    public LastAssemblyNode XDocument { get; init; }
    public LastAssemblyNode Serialization { get; init; }
    public LastAssemblyNode ReaderWriter { get; init; }
    public LastAssemblyNode Linq { get; init; }
}

public class XmlXPathAssemblyNode : AssemblyNodeBase
{
    public XmlXPathAssemblyNode(string assemblyName, IAssemblyNode? parent = null) : base(assemblyName, parent)
    {
        XDocument = new("XDocument", this);
    }

    public LastAssemblyNode XDocument { get; init; }
}