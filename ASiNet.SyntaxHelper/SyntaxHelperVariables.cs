using ASiNet.SyntaxHelper.Base;
using ASiNet.SyntaxHelper.Enums;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ASiNet.SyntaxHelper;
public static partial class SyntaxHelper
{
    public static TypeSyntax TypeSyntaxFrom(PredefinedType type) =>
        SyntaxFactory.PredefinedType(SyntaxFactory.Token(Helper.GetSyntaxKindFromPredefinedType(type)));

    public static TypeSyntax TypeSyntaxFrom(SyntaxKind type) =>
        SyntaxFactory.PredefinedType(SyntaxFactory.Token(type));

    public static TypeSyntax TypeSyntaxFrom(Type type) =>
        SyntaxFactory.ParseTypeName(type.Name);

    public static TypeSyntax TypeSyntaxFrom(string typeName) =>
        SyntaxFactory.ParseTypeName(typeName);


    public static ParameterSyntax MethodParameter(string name, TypeSyntax parameterType) =>
        SyntaxFactory.Parameter(
            SyntaxFactory.Identifier(name))
            .WithType(parameterType);

    public static ParameterSyntax MethodParameter(string name, string parameterTypeName) =>
        SyntaxFactory.Parameter(
            SyntaxFactory.Identifier(name))
            .WithType(
                SyntaxFactory.ParseTypeName(parameterTypeName));

    public static ParameterSyntax MethodParameter(string name, Type parameterType) =>
        SyntaxFactory.Parameter(
            SyntaxFactory.Identifier(name))
            .WithType(
                SyntaxFactory.ParseTypeName(parameterType.Name));
}
