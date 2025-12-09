namespace Clonify.Snippets.Declarations.Structs;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static class Unsupported
{
    public static readonly Snippets Declaration = new(
        Simple.Declaration.Body,
        new(
            $$"""
            namespace Clonify.Testing.Structs
            {
                [{{BodyTag}}]
                public struct Unsupported
                {
                }
            }
            """,
            LanguageVersion.CSharp2),
        [],
        [],
        nameof(Unsupported));
}