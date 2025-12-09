namespace Clonify.Snippets.Declarations.Records;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static class Unsupported
{
    public static readonly Snippets Declaration = new(
        Simple.Declaration.Body,
        new(
            $$"""
            namespace Clonify.Testing.Records
            {
                [{{BodyTag}}]
                public sealed record Unsupported
                {
                }
            }
            """,
            LanguageVersion.CSharp9),
        [],
        [],
        nameof(Unsupported));
}