using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ASiNet.SyntaxHelper;
public static partial class SyntaxHelper
{
    public static ArgumentSyntax VariableOrParameterArgument(string variableOrParameterName) =>
        SyntaxFactory.Argument(SyntaxFactory.ParseExpression(variableOrParameterName));


    public static StatementSyntax InvokeMethod(string typeName, string methodName, params ArgumentSyntax[] arguments) =>
        InvokeMethod(SyntaxFactory.IdentifierName(typeName), SyntaxFactory.IdentifierName(methodName), SyntaxKind.SimpleMemberAccessExpression, arguments);

    public static StatementSyntax InvokeMethod(Type type, string methodName, params ArgumentSyntax[] arguments) =>
        InvokeMethod(SyntaxFactory.IdentifierName(type.Name), SyntaxFactory.IdentifierName(methodName), SyntaxKind.SimpleMemberAccessExpression, arguments);

    public static StatementSyntax InvokeMethod(ExpressionSyntax expression, SimpleNameSyntax methodName, params ArgumentSyntax[] arguments) =>
        InvokeMethod(expression, methodName, SyntaxKind.SimpleMemberAccessExpression, arguments);

    public static StatementSyntax InvokeMethod(ExpressionSyntax expression, SimpleNameSyntax methodName, SyntaxKind kind, params ArgumentSyntax[] arguments) =>
        SyntaxFactory.ExpressionStatement(
            SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(
                    kind,
                    expression,
                    methodName),
                SyntaxFactory.ArgumentList()
                .AddArguments(arguments))
            );

}
