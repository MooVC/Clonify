namespace Clonify.Snippets.Declarations;

public static class Internal
{
    public static readonly Generated HashCode = new(
        HashCodeGenerator.Content,
        Extensions.None,
        "Clonify.Internal.HashCode",
        Generator: typeof(HashCodeGenerator));

    public static readonly Generated SequenceEqualityComparer = new(
        SequenceEqualityComparerGenerator.Content,
        Extensions.None,
        "Clonify.Internal.SequenceEqualityComparer",
        Generator: typeof(SequenceEqualityComparerGenerator));
}