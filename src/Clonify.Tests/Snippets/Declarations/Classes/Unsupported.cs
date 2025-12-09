namespace Clonify.Snippets.Declarations.Classes;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static class Unsupported
{
    public static readonly Snippets Declaration = new(
        Simple.Declaration.Body,
        new(
            $$"""
            namespace Clonify.Testing.Classes
            {
                [{{BodyTag}}]
                public sealed class Unsupported
                {
                }
            }
            """,
            LanguageVersion.CSharp2),
        [],
        [],
        nameof(Unsupported));
}