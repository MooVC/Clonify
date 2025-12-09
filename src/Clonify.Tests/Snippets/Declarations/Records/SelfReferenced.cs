namespace Clonify.Snippets.Declarations.Records;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Declarations.Classes.SelfReferenced.Annotations;
using static Clonify.Snippets.Snippets;

internal static partial class SelfReferenced
{
    public static readonly Snippets Declaration = new(
        [Generic, NonGeneric],
        new(
            $$"""
            namespace Clonify.Testing.Records
            {
                [{{BodyTag}}]
                public sealed partial record SelfReferenced
                {
                }
            }
            """,
            LanguageVersion.CSharp9),
        [],
        [],
        nameof(SelfReferenced));
}