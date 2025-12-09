namespace Clonify.AttributeAnalyzerTests;

using System.Text;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using Clonify;
using Clonify.Snippets;
using Clonify.Snippets.Declarations;
using AnalyzerTest = Clonify.AnalyzerTest<Clonify.AttributeAnalyzer>;
using SelfReferencedClass = Clonify.Snippets.Declarations.Classes.SelfReferenced;
using SelfReferencedRecord = Clonify.Snippets.Declarations.Records.SelfReferenced;
using SelfReferencedStruct = Clonify.Snippets.Declarations.Structs.SelfReferenced;
using UnannotatedClass = Clonify.Snippets.Declarations.Classes.Unannotated;
using UnannotatedRecord = Clonify.Snippets.Declarations.Records.Unannotated;
using UnannotatedStruct = Clonify.Snippets.Declarations.Structs.Unannotated;
using UnsupportedClass = Clonify.Snippets.Declarations.Classes.Unsupported;
using UnsupportedRecord = Clonify.Snippets.Declarations.Records.Unsupported;
using UnsupportedStruct = Clonify.Snippets.Declarations.Structs.Unsupported;

public sealed class WhenExecuted
{
    [Theory]
    [Snippets(
        exclusions:
        [
            typeof(Attributes),
            typeof(SelfReferencedClass),
            typeof(SelfReferencedRecord),
            typeof(SelfReferencedStruct),
            typeof(UnannotatedClass),
            typeof(UnsupportedClass),
            typeof(UnannotatedRecord),
            typeof(UnsupportedRecord),
            typeof(UnannotatedStruct),
            typeof(UnsupportedStruct),
        ],
        extensions: Extensions.None)]
    public async Task GivenATypeWhenCompliantThenNoDiagnosticsAreRaised(ReferenceAssemblies assembly, Expectations expectations, LanguageVersion language)
    {
        // Arrange
        var test = new AnalyzerTest(assembly, language);

        expectations.IsDeclaredIn(test.TestState);

        // Act
        Func<Task> act = () => test.RunAsync();

        // Assert
        await act.ShouldNotThrowAsync();
    }

    [Theory]
    [Snippets(exclusions: [typeof(Attributes)], inclusions: [typeof(UnsupportedClass), typeof(UnsupportedRecord), typeof(UnsupportedStruct)])]
    public async Task GivenATypeWhenNotPartialThenPartialTypeRuleIsRaised(ReferenceAssemblies assembly, Expectations expectations, LanguageVersion language)
    {
        // Arrange
        var test = new AnalyzerTest(assembly, language);

        test.ExpectedDiagnostics.Add(GetExpectedPartialTypeRule(new LinePosition(2, 5), UnsupportedStruct.Declaration.Name));
        expectations.IsDeclaredIn(test.TestState);

        // Act
        Func<Task> act = () => test.RunAsync();

        // Assert
        await act.ShouldNotThrowAsync();
    }

    [Theory]
    [Snippets(exclusions: [typeof(Attributes)], inclusions: [typeof(SelfReferencedClass), typeof(SelfReferencedRecord), typeof(SelfReferencedStruct)])]
    public async Task GivenATypeWhenSelfReferencedThenSelfReferencingRuleIsRaised(ReferenceAssemblies assembly, Expectations expectations, LanguageVersion language)
    {
        // Arrange
        var test = new AnalyzerTest(assembly, language);

        test.ExpectedDiagnostics.Add(GetExpectedSelfReferenceRule(new LinePosition(2, 5), SelfReferencedClass.Declaration.Name));
        expectations.IsDeclaredIn(test.TestState);

        // Act
        Func<Task> act = () => test.RunAsync();

        // Assert
        await act.ShouldNotThrowAsync();
    }

    [Theory]
    [Frameworks(Language = LanguageVersion.CSharp11)]
    public async Task GivenAClassWhenNoStateExistsThenCapturesStateRuleIsNotRaised(ReferenceAssemblies assembly, LanguageVersion language)
    {
        // Arrange
        var test = new AnalyzerTest(assembly, language);

        test.TestState.Sources.Add(
            SourceText.From(
                """
                namespace Clonify.Tests;

                [Clonify<string>]
                public partial class Inner
                {
                }
                """,
                Encoding.UTF8));

        // Act
        Func<Task> act = () => test.RunAsync();

        // Assert
        await act.ShouldNotThrowAsync();
    }

    [Theory]
    [Frameworks(Language = LanguageVersion.CSharp11)]
    public async Task GivenAPositionalRecordWhenOnlyImplicitStateExistsThenCapturesStateRuleIsRaised(ReferenceAssemblies assembly, LanguageVersion language)
    {
        // Arrange
        var test = new AnalyzerTest(assembly, language);

        test.TestState.Sources.Add(
            SourceText.From(
                """
                namespace Clonify.Tests;

                [Clonify<int>]
                public partial record Age(int Amount);
                """,
                Encoding.UTF8));

        // Act
        Func<Task> act = () => test.RunAsync();

        // Assert
        _ = await act.ShouldThrowAsync<InvalidOperationException>();
    }

    private static DiagnosticResult GetExpectedPartialTypeRule(LinePosition position, string @class)
    {
        return new DiagnosticResult(AttributeAnalyzer.PartialTypeRule)
            .WithLocation(position)
            .WithArguments(@class);
    }

    private static DiagnosticResult GetExpectedSelfReferenceRule(LinePosition position, string @class)
    {
        return new DiagnosticResult(AttributeAnalyzer.SelfReferenceRule)
            .WithLocation(position)
            .WithArguments(@class);
    }
}