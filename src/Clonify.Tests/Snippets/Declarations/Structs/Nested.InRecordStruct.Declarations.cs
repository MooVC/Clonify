namespace Clonify.Snippets.Declarations.Structs;

using Microsoft.CodeAnalysis.CSharp;
using static Clonify.Snippets.Snippets;

internal static partial class Nested
{
    public static partial class InRecordStruct
    {
        public static class Declarations
        {
            public static readonly Content Main = new(
                $$"""
                namespace Clonify.Testing.Structs
                {
                    public readonly partial record struct Outter<T>
                        where T : struct
                    {
                        [{{BodyTag}}]
                        public readonly partial struct Inner
                        {
                        }
                    }
                }
                """,
                LanguageVersion.CSharp10);
        }
    }
}