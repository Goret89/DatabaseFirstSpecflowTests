using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.86")]
[SetUpFixture]
public class DatabaseFirstProject2_Tests_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(DatabaseFirstProject2_Tests_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(DatabaseFirstProject2_Tests_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
