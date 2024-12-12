using Microsoft.Extensions.DependencyInjection;
using Soenneker.GitHub.Artifacts.Registrars;
using Soenneker.GitHub.BranchPolicies.Registrars;
using Soenneker.GitHub.Repositories.PullRequests.Registrars;
using Soenneker.GitHub.Repositories.Secrets.Registrars;

namespace Soenneker.GitHub.Repositories.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for GitHub's Repository related operations
/// </summary>
public static class GitHubRepositorySuiteRegistrar
{
    public static IServiceCollection AddGitHubRepositoriesSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesPullRequestsUtilAsSingleton();
        services.AddGitHubRepositoriesSecretsUtilAsSingleton();
        services.AddGitHubBranchPoliciesUtilAsSingleton();
        services.AddGitHubArtifactsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddGitHubRepositoriesSuiteAsScoped(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesPullRequestsUtilAsScoped();
        services.AddGitHubRepositoriesSecretsUtilAsScoped();
        services.AddGitHubBranchPoliciesUtilAsScoped();
        services.AddGitHubArtifactsUtilAsScoped();

        return services;
    }
}
