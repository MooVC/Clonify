namespace Clonify.Semantics;

using Microsoft.CodeAnalysis;

using static Clonify.AttributeGenerator;

/// <summary>
/// Provides extensions relating to <see cref="INamedTypeSymbol"/>.
/// </summary>
internal static partial class INamedTypeSymbolExtensions
{
    /// <summary>
    /// Determines whether or not the <paramref name="symbol"/> provided is annotated with the Clonify attribute.
    /// </summary>
    /// <param name="symbol">The symbol for the record to be checked for the presence of the Clonify attribute.</param>
    /// <returns>True if the Clonify attribute is present on the <paramref name="symbol"/>, otherwise False.</returns>
    public static bool HasClonify(this INamedTypeSymbol symbol)
    {
        return symbol.HasAttribute(Name);
    }
}