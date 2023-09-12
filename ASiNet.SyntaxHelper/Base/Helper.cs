using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASiNet.SyntaxHelper.Enums;
using Microsoft.CodeAnalysis.CSharp;

namespace ASiNet.SyntaxHelper.Base;
internal static class Helper
{
    public static SyntaxKind GetSyntaxKindFromPredefinedType(PredefinedType type) => type switch
    { 
        PredefinedType.Bool => SyntaxKind.BoolKeyword,
        PredefinedType.Byte => SyntaxKind.ByteKeyword,
        PredefinedType.Char => SyntaxKind.CharKeyword,
        PredefinedType.Decimal => SyntaxKind.DecimalKeyword,
        PredefinedType.Double => SyntaxKind.DoubleKeyword,
        PredefinedType.Float => SyntaxKind.FloatKeyword,
        PredefinedType.Int => SyntaxKind.IntKeyword,
        PredefinedType.Long => SyntaxKind.LongKeyword,
        PredefinedType.Object => SyntaxKind.ObjectKeyword,
        PredefinedType.SByte => SyntaxKind.SByteKeyword,
        PredefinedType.Short => SyntaxKind.ShortKeyword,
        PredefinedType.String => SyntaxKind.StringKeyword,
        PredefinedType.UInt => SyntaxKind.UIntKeyword,
        PredefinedType.ULong => SyntaxKind.ULongKeyword,
        PredefinedType.UShort => SyntaxKind.UShortKeyword,
        _ => throw new NotImplementedException(),
    };

    public static IEnumerable<SyntaxKind> GetSyntaxKindsFromMemberModifiers(MemberModifiers modifiers)
    {
        if (modifiers.HasFlag(MemberModifiers.PrivateProtected) ||
            modifiers.HasFlag(MemberModifiers.Private) &&
            modifiers.HasFlag(MemberModifiers.Protected))
        {
            yield return SyntaxKind.PrivateKeyword;
            yield return SyntaxKind.ProtectedKeyword;
        }
        else if (modifiers.HasFlag(MemberModifiers.ProtectedInternal) ||
            modifiers.HasFlag(MemberModifiers.Internal) &&
            modifiers.HasFlag(MemberModifiers.Protected))
        {
            yield return SyntaxKind.ProtectedKeyword;
            yield return SyntaxKind.InternalKeyword;
        }
        else
        {
            if (modifiers.HasFlag(MemberModifiers.Public))
                yield return SyntaxKind.PublicKeyword;
            else if (modifiers.HasFlag(MemberModifiers.Internal))
                yield return SyntaxKind.InternalKeyword;
            else if (modifiers.HasFlag(MemberModifiers.Protected))
                yield return SyntaxKind.ProtectedKeyword;
            else if (modifiers.HasFlag(MemberModifiers.Private))
                yield return SyntaxKind.PrivateKeyword;
            else if (modifiers.HasFlag(MemberModifiers.File))
                yield return SyntaxKind.FileKeyword;
        }

        if (modifiers.HasFlag(MemberModifiers.Static))
            yield return SyntaxKind.StaticKeyword;
        if (modifiers.HasFlag(MemberModifiers.Async))
            yield return SyntaxKind.AsyncKeyword;
        if (modifiers.HasFlag(MemberModifiers.Event))
            yield return SyntaxKind.EventKeyword;
        if (modifiers.HasFlag(MemberModifiers.Unsafe))
            yield return SyntaxKind.UnsafeKeyword;

        if (modifiers.HasFlag(MemberModifiers.Virtual))
            yield return SyntaxKind.VirtualKeyword;
        if (modifiers.HasFlag(MemberModifiers.Abstract))
            yield return SyntaxKind.AbstractKeyword;
        if (modifiers.HasFlag(MemberModifiers.Override))
            yield return SyntaxKind.OverrideKeyword;
        if (modifiers.HasFlag(MemberModifiers.Partial))
            yield return SyntaxKind.PartialKeyword;
    }
}
