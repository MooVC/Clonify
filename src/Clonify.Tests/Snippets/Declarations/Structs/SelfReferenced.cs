namespace Clonify.Snippets.Declarations.Structs;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Declarations.Classes.SelfReferenced.Annotations;
using static Clonify.Snippets.Snippets;

internal static partial class SelfReferenced
{
    public static readonly Snippets Declaration = new(
        [Generic, NonGeneric],
        new(
            $$"""
            namespace Clonify.Testing.Structs
            {
                [{{BodyTag}}]
                public partial struct SelfReferenced
                {
                }
            }
            """,
            LanguageVersion.CSharp2),
        [],
        [],
        nameof(SelfReferenced));
}