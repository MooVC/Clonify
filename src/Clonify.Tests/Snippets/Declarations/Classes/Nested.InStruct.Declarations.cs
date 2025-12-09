namespace Clonify.Snippets.Declarations.Classes;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static partial class Nested
{
    public static partial class InStruct
    {
        public static class Declarations
        {
            public static readonly Content Main = new(
                $$"""
                namespace Clonify.Testing.Classes
                {
                    public readonly ref partial struct Outter<T>
                        where T : struct
                    {
                        [{{BodyTag}}]
                        public sealed partial class Inner
                        {
                        }
                    }
                }
                """,
                LanguageVersion.CSharp7_2);
        }
    }
}