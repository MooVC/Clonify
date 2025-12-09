namespace Clonify.Snippets.Declarations.Records;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static partial class Nested
{
    public static partial class InClass
    {
        public static class Declarations
        {
            public static readonly Content Main = new(
                $$"""
                namespace Clonify.Testing.Records
                {
                    public sealed partial class Outter<T>
                        where T : struct
                    {
                        [{{BodyTag}}]
                        public sealed partial record Inner
                        {
                        }
                    }
                }
                """,
                LanguageVersion.CSharp9);
        }
    }
}