namespace Clonify.Snippets.Declarations.Classes;

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
                namespace Clonify.Testing.Classes
                {
                    public readonly partial record struct Outter<T>
                        where T : struct
                    {
                        [{{BodyTag}}]
                        public sealed partial class Inner
                        {
                        }
                    }
                }
                """,
                LanguageVersion.CSharp10);
        }
    }
}