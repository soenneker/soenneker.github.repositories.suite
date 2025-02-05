using Microsoft.Extensions.DependencyInjection;
using Soenneker.GitHub.Repositories.Discussions.Registrars;
using Soenneker.GitHub.Repositories.Issues.Registrars;
using Soenneker.GitHub.Repositories.PullRequests.Registrars;
using Soenneker.GitHub.Repositories.Readmes.Registrars;
using Soenneker.GitHub.Repositories.Releases.Registrars;
using Soenneker.GitHub.Repositories.Rulesets.Registrars;
using Soenneker.GitHub.Repositories.Secrets.Registrars;

namespace Soenneker.GitHub.Repositories.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for GitHub's Repository related operations
/// </summary>
public static class GitHubRepositorySuiteRegistrar
{
    public static IServiceCollection AddGitHubRepositoriesSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesReleasesUtilAsSingleton()
                .AddGitHubRepositoriesReadmesUtilAsSingleton()
                .AddGitHubRepositoriesPullRequestsUtilAsSingleton()
                .AddGitHubRepositoriesSecretsUtilAsSingleton()
                .AddGitHubRepositoriesIssuesUtilAsSingleton()
                .AddGitHubRepositoriesRulesetsUtilAsSingleton()
                .AddGitHubRepositoriesDiscussionsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddGitHubRepositoriesSuiteAsScoped(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesReleasesUtilAsScoped()
                .AddGitHubRepositoriesReadmesUtilAsScoped()
                .AddGitHubRepositoriesPullRequestsUtilAsScoped()
                .AddGitHubRepositoriesSecretsUtilAsScoped()
                .AddGitHubRepositoriesIssuesUtilAsScoped()
                .AddGitHubRepositoriesRulesetsUtilAsScoped()
                .AddGitHubRepositoriesDiscussionsUtilAsScoped();

        return services;
    }
}