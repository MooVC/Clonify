namespace Clonify.Snippets.Declarations;

using Microsoft.CodeAnalysis.CSharp;

public static partial class Attributes
{
    public static class Annotations
    {
        public static readonly Content Generic = new("global::Clonify.ClonifyAttribute<int>", LanguageVersion.CSharp11);

        public static readonly Content NonGeneric = new("Clonify(Type = typeof(int))", LanguageVersion.CSharp2);
    }
}