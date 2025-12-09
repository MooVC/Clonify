namespace Clonify.Snippets.Declarations.Records;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static partial class Simple
{
    public static class Declarations
    {
        public static readonly Content Main = new(
            $$"""
            namespace Clonify.Testing.Records
            {
                [{{BodyTag}}]
                public partial record Simple;
            }
            """,
            LanguageVersion.CSharp9);
    }
}