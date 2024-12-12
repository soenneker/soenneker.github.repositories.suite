using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.GitHub.Repositories.Suite.Tests;

[Collection("Collection")]
public class GitHubRepositorySuiteTests : FixturedUnitTest
{
    public GitHubRepositorySuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
