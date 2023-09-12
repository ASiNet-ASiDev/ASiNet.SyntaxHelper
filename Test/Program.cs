using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using ASiNet.SyntaxHelper;
using ASiNet.SyntaxHelper.Enums;
using ASiNet.AssemblysHelper;

var d = SyntaxFactory.CompilationUnit()
.AddMembers(
    SyntaxFactory.NamespaceDeclaration(
        SyntaxFactory.IdentifierName("TestAssembly")
        )
        .AddMembers(
            SyntaxFactory.ClassDeclaration("TestClass")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword)
                )
                .AddMembers(
                    SyntaxHelper.MethodDeclaration(
                        "TestMethod",
                        MemberModifiers.Public | MemberModifiers.Static,
                        SyntaxHelper.MethodParameter("str", nameof(String)))
                .WithBody(
                    SyntaxFactory.Block(
                        SyntaxHelper.InvokeMethod(typeof(Console), nameof(Console.WriteLine), SyntaxHelper.VariableOrParameterArgument("str"))
                        )
                    )
                )
            )
        )
    .AddUsings(
        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System"))
    ).NormalizeWhitespace();

Console.WriteLine(d.ToFullString());

var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

var asm = CSharpCompilation.Create(
    "TestAssembly",
    new SyntaxTree[]
    {
        d.SyntaxTree
    },
    new MetadataReference[]
    {
        MetadataReference.CreateFromFile(AssemblyTrees.Shared.System),
        MetadataReference.CreateFromFile(AssemblyTrees.Shared.System.Private.CoreLib),
        MetadataReference.CreateFromFile(AssemblyTrees.Shared.System.Console),
        MetadataReference.CreateFromFile(AssemblyTrees.Shared.System.Runtime),
        MetadataReference.CreateFromFile(AssemblyTrees.Shared.System.Core),
    },
    options);

var result = asm.Emit(@"C:\Users\Alexa\OneDrive\Рабочий стол\TestAssembly.dll");

Console.WriteLine($"Is builded: {result.Success}\n");

Console.WriteLine(string.Join("\n\n#", result.Diagnostics.Select(x => $"{x.Id} {x.Descriptor.MessageFormat}")));

Console.ReadKey();