using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitHub.Repositories.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GitHubRepositorySuiteTests : HostedUnitTest
{
    public GitHubRepositorySuiteTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    { 
    }
}
