using ASiNet.SyntaxHelper.Base;
using ASiNet.SyntaxHelper.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ASiNet.SyntaxHelper;
public static partial class SyntaxHelper
{
    #region void method
    /// <summary>
    /// Generate method with <see cref="void"/> as return type
    /// </summary>
    /// <param name="name">Method Name</param>
    /// <param name="modifiers">Modifiers: All access modifiers, <see cref="async"/>, <see cref="static"/>, <see cref="virtual"/>, and other.</param>
    /// <param name="parameters"></param>
    public static MethodDeclarationSyntax MethodDeclaration(string name, MemberModifiers modifiers, params ParameterSyntax[] parameters) =>
        MethodDeclaration(name, SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), modifiers, parameters);
    #endregion

    #region other methods
    /// <summary>
    /// Generate method with custom return type
    /// </summary>
    /// <param name="returnType">predefined return type</param>
    /// <param name="name">Method Name</param>
    /// <param name="modifiers">Modifiers: All access modifiers, <see cref="async"/>, <see cref="static"/>, <see cref="virtual"/>, and other.</param>
    /// <param name="parameters"></param>
    public static MethodDeclarationSyntax MethodDeclaration(string name, SyntaxKind returnType, MemberModifiers modifiers, params ParameterSyntax[] parameters) =>
        MethodDeclaration(name, TypeSyntaxFrom(returnType), modifiers, parameters);

    /// <summary>
    /// Generate method with custom return type
    /// </summary>
    /// <param name="returnTypeName">return type name</param>
    /// <param name="name">Method Name</param>
    /// <param name="modifiers">Modifiers: All access modifiers, <see cref="async"/>, <see cref="static"/>, <see cref="virtual"/>, and other.</param>
    /// <param name="parameters"></param>
    public static MethodDeclarationSyntax MethodDeclaration(string name, string returnTypeName, MemberModifiers modifiers, params ParameterSyntax[] parameters) =>
        MethodDeclaration(name, TypeSyntaxFrom(returnTypeName), modifiers, parameters);

    /// <summary>
    /// Generate method with custom return type
    /// </summary>
    /// <param name="returnType">predefined return type</param>
    /// <param name="name">Method Name</param>
    /// <param name="modifiers">Modifiers: All access modifiers, <see cref="async"/>, <see cref="static"/>, <see cref="virtual"/>, and other.</param>
    /// <param name="parameters"></param>
    public static MethodDeclarationSyntax MethodDeclaration(string name, PredefinedType returnType, MemberModifiers modifiers, params ParameterSyntax[] parameters) =>
        MethodDeclaration(name, TypeSyntaxFrom(returnType), modifiers, parameters);

    #endregion

    /// <summary>
    /// Generate method with custom return type
    /// </summary>
    /// <param name="returnType">return type</param>
    /// <param name="name">Method Name</param>
    /// <param name="modifiers">Modifiers: All access modifiers, <see cref="async"/>, <see cref="static"/>, <see cref="virtual"/>, and other.</param>
    /// <param name="parameters"></param>
    public static MethodDeclarationSyntax MethodDeclaration(string name, TypeSyntax returnType, MemberModifiers modifiers, params ParameterSyntax[] parameters) => 
        SyntaxFactory.MethodDeclaration(
            returnType, 
            name)
            .AddParameterListParameters(parameters)
            .AddModifiers(
                Helper.GetSyntaxKindsFromMemberModifiers(modifiers)
                    .Select(SyntaxFactory.Token)
                        .ToArray());
}
