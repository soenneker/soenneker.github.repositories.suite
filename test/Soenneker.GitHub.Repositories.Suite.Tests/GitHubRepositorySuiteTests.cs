using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.GitHub.Repositories.Suite.Tests;

[Collection("Collection")]
public class GitHubRepositorySuiteTests : FixturedUnitTest
{
    public GitHubRepositorySuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
