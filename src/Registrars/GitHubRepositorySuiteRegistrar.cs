using Microsoft.Extensions.DependencyInjection;
using Soenneker.GitHub.Repositories.Issues.Registrars;
using Soenneker.GitHub.Repositories.PullRequests.Registrars;
using Soenneker.GitHub.Repositories.Readmes.Registrars;
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
        services.AddGitHubRepositoriesReadmesUtilAsSingleton();
        services.AddGitHubRepositoriesPullRequestsUtilAsSingleton();
        services.AddGitHubRepositoriesSecretsUtilAsSingleton();
        services.AddGitHubRepositoriesIssuesUtilAsSingleton();
        services.AddGitHubRepositoriesRulesetsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddGitHubRepositoriesSuiteAsScoped(this IServiceCollection services)
    {
        services.AddGitHubRepositoriesReadmesUtilAsScoped();
        services.AddGitHubRepositoriesPullRequestsUtilAsScoped();
        services.AddGitHubRepositoriesSecretsUtilAsScoped();
        services.AddGitHubRepositoriesIssuesUtilAsScoped();
        services.AddGitHubRepositoriesRulesetsUtilAsScoped();

        return services;
    }
}