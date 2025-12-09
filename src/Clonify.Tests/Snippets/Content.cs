namespace Clonify.Snippets;

using Microsoft.CodeAnalysis.CSharp;

public sealed record Content(string Body, LanguageVersion Minimum);