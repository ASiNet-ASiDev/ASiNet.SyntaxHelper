namespace ASiNet.SyntaxHelper.Enums;

[Flags]
public enum MemberModifiers : ushort
{
    None = 0,

    Public = 1 << 0,
    Private = 1 << 1,
    Protected = 1 << 2,
    Internal = 1 << 3,

    PrivateProtected = 1 << 13,
    ProtectedInternal = 1 << 14,

    Static = 1 << 4,
    Async = 1 << 5,
    Event = 1 << 6,
    Unsafe = 1 << 7,

    Partial = 1 << 8,
    Override = 1 << 9,
    Virtual = 1 << 10,
    Abstract = 1 << 11,

    File = 1 << 12,
}
