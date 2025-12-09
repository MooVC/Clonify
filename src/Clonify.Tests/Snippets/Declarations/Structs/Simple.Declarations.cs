namespace Clonify.Snippets.Declarations.Structs;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static partial class Simple
{
    public static class Declarations
    {
        public static readonly Content Main = new(
            $$"""
            namespace Clonify.Testing.Structs
            {
                [{{BodyTag}}]
                public partial struct Simple
                {
                }
            }
            """,
            LanguageVersion.CSharp2);
    }
}