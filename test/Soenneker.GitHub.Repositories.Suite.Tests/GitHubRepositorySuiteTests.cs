using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.GitHub.Repositories.Suite.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.GitHub.Repositories.Suite.Tests;

[Collection("Collection")]
public class GitHubRepositorySuiteTests : FixturedUnitTest
{
    private readonly IGitHubRepositorySuite _util;

    public GitHubRepositorySuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IGitHubRepositorySuite>(true);
    }
}
